# Birth Run 001 — Mechanical Transcript

Generated mechanically from production public simulation surfaces. No interpretation is included.

## Declared initial state
- P1 Hani: sex=Female; grain=6; NeedsGrain=False; dwelling=D2
- P2 Luma: sex=Male; grain=1; NeedsGrain=False; dwelling=D2
- P3 Iri: sex=Female; grain=3; NeedsGrain=False; dwelling=D1
- P4 Gala: sex=Female; grain=8; NeedsGrain=False; dwelling=D1

## Cycle 1

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=120 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=114 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=90 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P1: actor=Hani [P1]; Committed; reason=; event=E12
- Proposal P2: actor=Luma [P2]; Committed; reason=; event=E13
- Proposal P3: actor=Iri [P3]; Committed; reason=; event=E14
- Proposal P4: actor=Gala [P4]; Committed; reason=; event=E15

### Semantic events
- E1 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E2 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E3 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E4 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:8->7:ConsumptionSink]
- E5 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E6 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E7 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E8 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E9 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E10 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E11 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E12 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:5->4:Gift; P3:2->3:Gift]
- E13 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E14 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:4->5:Gift]
- E15 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:7->6:Gift; P1:5->6:Gift]
- E16 r15: AttitudeComposition; participants=[P1,P3]; detail=40->50; fallback=False
- E17 r16: AttitudeComposition; participants=[P1,P4]; detail=25->35; fallback=False
- E18 r17: AttitudeComposition; participants=[P3,P1]; detail=38->48; fallback=False

### Stable state
- Hani [P1]: grain=6; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=2; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=6; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 2

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=150 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=144 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=90 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P5: actor=Hani [P1]; Committed; reason=; event=E30
- Proposal P6: actor=Luma [P2]; Committed; reason=; event=E31
- Proposal P7: actor=Iri [P3]; Committed; reason=; event=E32
- Proposal P8: actor=Gala [P4]; Committed; reason=; event=E33

### Semantic events
- E19 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E20 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E21 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E22 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E23 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E24 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E25 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E26 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E27 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E28 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E29 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E30 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:5->4:Gift; P3:1->2:Gift]
- E31 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E32 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:4->5:Gift]
- E33 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:5->4:Gift; P1:5->6:Gift]
- E34 r15: AttitudeComposition; participants=[P1,P3]; detail=50->60; fallback=False
- E35 r16: AttitudeComposition; participants=[P1,P4]; detail=35->45; fallback=False
- E36 r17: AttitudeComposition; participants=[P3,P1]; detail=48->58; fallback=False

### Stable state
- Hani [P1]: grain=6; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=7; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=1; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 3

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=180 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=26 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=90 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P9: actor=Hani [P1]; Committed; reason=; event=E48
- Proposal P10: actor=Luma [P2]; Committed; reason=; event=E49
- Proposal P11: actor=Iri [P3]; Committed; reason=; event=E50
- Proposal P12: actor=Gala [P4]; Committed; reason=; event=E51

### Semantic events
- E37 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E38 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E39 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E40 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E41 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E42 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E43 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E44 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E45 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E46 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E47 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E48 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:5->4:Gift; P3:0->1:Gift]
- E49 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:6->5:Gift; P3:1->2:Gift]
- E50 r13: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:2->6:FarmSource]
- E51 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:4->5:Gift]
- E52 r15: AttitudeComposition; participants=[P1,P4]; detail=45->55; fallback=False
- E53 r16: AttitudeComposition; participants=[P3,P1]; detail=58->68; fallback=False
- E54 r17: AttitudeComposition; participants=[P3,P2]; detail=-26->-16; fallback=False

### Stable state
- Hani [P1]: grain=5; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=6; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 4

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=180 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=26 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=204 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=90 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P13: actor=Hani [P1]; Committed; reason=; event=E67
- Proposal P14: actor=Luma [P2]; Committed; reason=; event=E68
- Proposal P15: actor=Iri [P3]; Committed; reason=; event=E69
- Proposal P16: actor=Gala [P4]; Committed; reason=; event=E70

### Semantic events
- E55 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E56 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E57 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E58 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E59 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E60 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E61 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E62 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E63 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E64 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E65 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E66 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E67 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:4->3:Gift; P3:5->6:Gift]
- E68 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:6->7:Gift]
- E69 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:7->6:Gift; P1:3->4:Gift]
- E70 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:1->0:Gift; P1:4->5:Gift]
- E71 r16: AttitudeComposition; participants=[P1,P3]; detail=60->70; fallback=False
- E72 r17: AttitudeComposition; participants=[P1,P4]; detail=55->65; fallback=False
- E73 r18: AttitudeComposition; participants=[P3,P1]; detail=68->78; fallback=False
- E74 r19: AttitudeComposition; participants=[P3,P2]; detail=-16->-6; fallback=False

### Stable state
- Hani [P1]: grain=5; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=6; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=0; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 5

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=204 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=228 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P17: actor=Hani [P1]; Committed; reason=; event=E98
- Proposal P18: actor=Luma [P2]; Committed; reason=; event=E99
- Proposal P19: actor=Iri [P3]; Committed; reason=; event=E100
- Proposal P20: actor=Gala [P4]; Committed; reason=; event=E101

### Semantic events
- E75 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E76 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E77 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E78 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E79 r4: AttitudeDecay; participants=[P1,P2]; detail=-19->-18; fallback=False
- E80 r5: AttitudeDecay; participants=[P1,P3]; detail=70->68; fallback=False
- E81 r6: AttitudeDecay; participants=[P1,P4]; detail=65->63; fallback=False
- E82 r7: AttitudeDecay; participants=[P2,P1]; detail=-28->-27; fallback=False
- E83 r8: AttitudeDecay; participants=[P2,P3]; detail=13->11; fallback=False
- E84 r9: AttitudeDecay; participants=[P2,P4]; detail=4->2; fallback=False
- E85 r10: AttitudeDecay; participants=[P3,P1]; detail=78->76; fallback=False
- E86 r11: AttitudeDecay; participants=[P3,P2]; detail=-6->-5; fallback=False
- E87 r12: AttitudeDecay; participants=[P3,P4]; detail=-16->-15; fallback=False
- E88 r13: AttitudeDecay; participants=[P4,P1]; detail=45->43; fallback=False
- E89 r14: AttitudeDecay; participants=[P4,P2]; detail=22->20; fallback=False
- E90 r15: AttitudeDecay; participants=[P4,P3]; detail=37->35; fallback=False
- E91 r16: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E92 r17: Response; participants=[P3]; detail=Accept; fallback=False
- E93 r18: Proposal; participants=[P2]; detail=Farm; fallback=False
- E94 r19: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E95 r20: Response; participants=[P1]; detail=Accept; fallback=False
- E96 r21: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E97 r22: Response; participants=[P1]; detail=Accept; fallback=False
- E98 r23: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:4->3:Gift; P3:5->6:Gift]
- E99 r24: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:2->6:FarmSource]
- E100 r25: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:6->5:Gift; P1:3->4:Gift]
- E101 r26: Help; participants=[P1,P4]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:4->3:Help; P4:0->1:Help]
- E102 r27: AttitudeComposition; participants=[P1,P3]; detail=68->78; fallback=False
- E103 r28: AttitudeComposition; participants=[P3,P1]; detail=76->86; fallback=False
- E104 r29: AttitudeComposition; participants=[P4,P1]; detail=43->53; fallback=False

### Stable state
- Hani [P1]: grain=3; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=5; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 6

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=234 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=22 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=258 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P21: actor=Hani [P1]; Committed; reason=; event=E116
- Proposal P22: actor=Luma [P2]; Committed; reason=; event=E117
- Proposal P23: actor=Iri [P3]; Committed; reason=; event=E118
- Proposal P24: actor=Gala [P4]; Committed; reason=; event=E119

### Semantic events
- E105 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E106 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E107 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E108 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E109 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E110 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E111 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E112 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E113 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E114 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E115 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E116 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:2->1:Gift; P3:4->5:Gift]
- E117 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:5->6:Gift]
- E118 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:6->5:Gift; P1:1->2:Gift]
- E119 r14: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E120 r15: AttitudeComposition; participants=[P1,P3]; detail=78->88; fallback=False
- E121 r16: AttitudeComposition; participants=[P3,P1]; detail=86->96; fallback=False
- E122 r17: AttitudeComposition; participants=[P3,P2]; detail=-5->5; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=5; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 7

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=264 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=288 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=106 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P25: actor=Hani [P1]; Committed; reason=; event=E134
- Proposal P26: actor=Luma [P2]; Committed; reason=; event=E135
- Proposal P27: actor=Iri [P3]; Committed; reason=; event=E136
- Proposal P28: actor=Gala [P4]; Committed; reason=; event=E137

### Semantic events
- E123 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E124 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E125 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E126 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E127 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E128 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E129 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E130 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E131 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E132 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E133 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E134 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:4->5:Gift]
- E135 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E136 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:5->4:Gift; P1:0->1:Gift]
- E137 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:1->2:Gift]
- E138 r15: AttitudeComposition; participants=[P1,P3]; detail=88->98; fallback=False
- E139 r16: AttitudeComposition; participants=[P1,P4]; detail=63->73; fallback=False
- E140 r17: AttitudeComposition; participants=[P3,P1]; detail=96->100; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=7; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=4; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 8

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=22 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=106 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P29: actor=Hani [P1]; Committed; reason=; event=E153
- Proposal P30: actor=Luma [P2]; Committed; reason=; event=E154
- Proposal P31: actor=Iri [P3]; Committed; reason=; event=E155
- Proposal P32: actor=Gala [P4]; Committed; reason=; event=E156

### Semantic events
- E141 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E142 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E143 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E144 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E145 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E146 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E147 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E148 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E149 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E150 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E151 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E152 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E153 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:3->4:Gift]
- E154 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:6->5:Gift; P3:4->5:Gift]
- E155 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:5->4:Gift; P1:0->1:Gift]
- E156 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:1->0:Gift; P1:1->2:Gift]
- E157 r16: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E158 r17: AttitudeComposition; participants=[P1,P4]; detail=73->83; fallback=False
- E159 r18: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E160 r19: AttitudeComposition; participants=[P3,P2]; detail=5->15; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=4; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=0; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 9

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=22 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P33: actor=Hani [P1]; Committed; reason=; event=E173
- Proposal P34: actor=Luma [P2]; Committed; reason=; event=E174
- Proposal P35: actor=Iri [P3]; Committed; reason=; event=E175
- Proposal P36: actor=Gala [P4]; Committed; reason=; event=E176

### Semantic events
- E161 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E162 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E163 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E164 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E165 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E166 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E167 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E168 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E169 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E170 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E171 r10: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E172 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E173 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=True material=[P1:1->0:Gift; P3:3->4:Gift]
- E174 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:4->5:Gift]
- E175 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=True material=[P3:5->4:Gift; P1:0->1:Gift]
- E176 r15: Help; participants=[P1,P4]; detail=RequestGiftOrHelp(1,1); fallback=True material=[P1:1->0:Help; P4:0->1:Help]
- E177 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E178 r17: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E179 r18: AttitudeComposition; participants=[P3,P2]; detail=15->25; fallback=False
- E180 r19: AttitudeComposition; participants=[P4,P1]; detail=53->63; fallback=False

### Stable state
- Hani [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=4; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 10

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P37: actor=Hani [P1]; Committed; reason=; event=E203
- Proposal P38: actor=Luma [P2]; Committed; reason=; event=E204
- Proposal P39: actor=Iri [P3]; Committed; reason=; event=E205
- Proposal P40: actor=Gala [P4]; Committed; reason=; event=E206

### Semantic events
- E181 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E182 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E183 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E184 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E185 r4: AttitudeDecay; participants=[P1,P2]; detail=-18->-17; fallback=False
- E186 r5: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E187 r6: AttitudeDecay; participants=[P1,P4]; detail=83->81; fallback=False
- E188 r7: AttitudeDecay; participants=[P2,P1]; detail=-27->-26; fallback=False
- E189 r8: AttitudeDecay; participants=[P2,P3]; detail=11->9; fallback=False
- E190 r9: AttitudeDecay; participants=[P2,P4]; detail=2->0; fallback=False
- E191 r10: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E192 r11: AttitudeDecay; participants=[P3,P2]; detail=25->23; fallback=False
- E193 r12: AttitudeDecay; participants=[P3,P4]; detail=-15->-14; fallback=False
- E194 r13: AttitudeDecay; participants=[P4,P1]; detail=63->61; fallback=False
- E195 r14: AttitudeDecay; participants=[P4,P2]; detail=20->18; fallback=False
- E196 r15: AttitudeDecay; participants=[P4,P3]; detail=35->33; fallback=False
- E197 r16: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E198 r17: Response; participants=[P2]; detail=Accept; fallback=False
- E199 r18: Proposal; participants=[P2]; detail=Farm; fallback=False
- E200 r19: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E201 r20: Response; participants=[P1]; detail=Accept; fallback=False
- E202 r21: Proposal; participants=[P4]; detail=Farm; fallback=False
- E203 r22: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:2->1:Help; P1:0->1:Help]
- E204 r23: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:1->5:FarmSource]
- E205 r24: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:1->2:Gift]
- E206 r25: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E207 r26: AttitudeComposition; participants=[P1,P2]; detail=-17->-7; fallback=False
- E208 r27: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=2; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 11

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=18 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=122 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P41: actor=Hani [P1]; Committed; reason=; event=E221
- Proposal P42: actor=Luma [P2]; Committed; reason=; event=E222
- Proposal P43: actor=Iri [P3]; Committed; reason=; event=E223
- Proposal P44: actor=Gala [P4]; Committed; reason=; event=E224

### Semantic events
- E209 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E210 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E211 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E212 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E213 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E214 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E215 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E216 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E217 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E218 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E219 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E220 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E221 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:1->2:Gift]
- E222 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:2->3:Gift]
- E223 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:0->1:Gift]
- E224 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:1->2:Gift]
- E225 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E226 r17: AttitudeComposition; participants=[P1,P4]; detail=81->91; fallback=False
- E227 r18: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False
- E228 r19: AttitudeComposition; participants=[P3,P2]; detail=23->33; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=2; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 12

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=122 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P45: actor=Hani [P1]; Committed; reason=; event=E240
- Proposal P46: actor=Luma [P2]; Committed; reason=; event=E241
- Proposal P47: actor=Iri [P3]; Committed; reason=; event=E242
- Proposal P48: actor=Gala [P4]; Committed; reason=; event=E243

### Semantic events
- E229 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E230 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E231 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E232 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E233 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E234 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E235 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E236 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E237 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E238 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E239 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E240 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:1->2:Gift]
- E241 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:2->6:FarmSource]
- E242 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:0->1:Gift]
- E243 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:1->0:Gift; P1:1->2:Gift]
- E244 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E245 r16: AttitudeComposition; participants=[P1,P4]; detail=91->100; fallback=False
- E246 r17: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=1; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=0; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 13

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=18 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P49: actor=Hani [P1]; Committed; reason=; event=E258
- Proposal P50: actor=Luma [P2]; Committed; reason=; event=E259
- Proposal P51: actor=Iri [P3]; Committed; reason=; event=E260
- Proposal P52: actor=Gala [P4]; InvalidatedAtResolution; reason=InsufficientAvailableGrain; event=E261

### Semantic events
- E247 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E248 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E249 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E250 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E251 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E252 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E253 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E254 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E255 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E256 r9: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E257 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E258 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=True material=[P1:1->0:Gift; P3:0->1:Gift]
- E259 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:1->2:Gift]
- E260 r13: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:2->6:FarmSource]
- E261 r14: InvalidatedAtResolution; participants=[P4,P1]; detail=InsufficientAvailableGrain; fallback=True
- E262 r15: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E263 r16: AttitudeComposition; participants=[P3,P2]; detail=33->43; fallback=False

### Stable state
- Hani [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=6; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 14

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/Feasibility: none; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P53: actor=Hani [P1]; Committed; reason=; event=E275
- Proposal P54: actor=Luma [P2]; Committed; reason=; event=E276
- Proposal P55: actor=Iri [P3]; Committed; reason=; event=E277
- Proposal P56: actor=Gala [P4]; Unable; reason=InsufficientAvailableGrain; event=E274

### Semantic events
- E264 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E265 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E266 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E267 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E268 r4: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E269 r5: Response; participants=[P2]; detail=Accept; fallback=False
- E270 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E271 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E272 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E273 r9: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E274 r10: Unable; participants=[P4,P1]; detail=InsufficientAvailableGrain; fallback=False
- E275 r11: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:3->2:Help; P1:0->1:Help]
- E276 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:2->6:FarmSource]
- E277 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:5->4:Gift; P1:1->2:Gift]
- E278 r14: AttitudeComposition; participants=[P1,P2]; detail=-7->3; fallback=False
- E279 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=4; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 15

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=14 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P57: actor=Hani [P1]; Committed; reason=; event=E304
- Proposal P58: actor=Luma [P2]; Committed; reason=; event=E305
- Proposal P59: actor=Iri [P3]; Committed; reason=; event=E306
- Proposal P60: actor=Gala [P4]; Committed; reason=; event=E307

### Semantic events
- E280 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E281 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E282 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E283 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E284 r4: AttitudeDecay; participants=[P1,P2]; detail=3->1; fallback=False
- E285 r5: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E286 r6: AttitudeDecay; participants=[P1,P4]; detail=100->98; fallback=False
- E287 r7: AttitudeDecay; participants=[P2,P1]; detail=-26->-25; fallback=False
- E288 r8: AttitudeDecay; participants=[P2,P3]; detail=9->7; fallback=False
- E289 r9: AttitudeDecay; participants=[P2,P4]; detail=0->0; fallback=False
- E290 r10: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E291 r11: AttitudeDecay; participants=[P3,P2]; detail=43->41; fallback=False
- E292 r12: AttitudeDecay; participants=[P3,P4]; detail=-14->-13; fallback=False
- E293 r13: AttitudeDecay; participants=[P4,P1]; detail=61->59; fallback=False
- E294 r14: AttitudeDecay; participants=[P4,P2]; detail=18->16; fallback=False
- E295 r15: AttitudeDecay; participants=[P4,P3]; detail=33->31; fallback=False
- E296 r16: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E297 r17: Response; participants=[P3]; detail=Accept; fallback=False
- E298 r18: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E299 r19: Response; participants=[P3]; detail=Accept; fallback=False
- E300 r20: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E301 r21: Response; participants=[P1]; detail=Accept; fallback=False
- E302 r22: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E303 r23: Response; participants=[P1]; detail=Accept; fallback=False
- E304 r24: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=True material=[P1:1->0:Gift; P3:3->4:Gift]
- E305 r25: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:4->5:Gift]
- E306 r26: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=True material=[P3:5->4:Gift; P1:0->1:Gift]
- E307 r27: Help; participants=[P1,P4]; detail=RequestGiftOrHelp(1,1); fallback=True material=[P1:1->0:Help; P4:0->1:Help]
- E308 r28: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E309 r29: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False
- E310 r30: AttitudeComposition; participants=[P3,P2]; detail=41->51; fallback=False
- E311 r31: AttitudeComposition; participants=[P4,P1]; detail=59->69; fallback=False

### Stable state
- Hani [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=4; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 16

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P61: actor=Hani [P1]; Committed; reason=; event=E322
- Proposal P62: actor=Luma [P2]; Committed; reason=; event=E323
- Proposal P63: actor=Iri [P3]; Committed; reason=; event=E324
- Proposal P64: actor=Gala [P4]; Committed; reason=; event=E325

### Semantic events
- E312 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E313 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E314 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E315 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E316 r4: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E317 r5: Response; participants=[P2]; detail=Accept; fallback=False
- E318 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E319 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E320 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E321 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E322 r10: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:3->2:Help; P1:0->1:Help]
- E323 r11: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:2->6:FarmSource]
- E324 r12: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:1->2:Gift]
- E325 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E326 r14: AttitudeComposition; participants=[P1,P2]; detail=1->11; fallback=False
- E327 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=2; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 17

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=14 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=138 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P65: actor=Hani [P1]; Committed; reason=; event=E340
- Proposal P66: actor=Luma [P2]; Committed; reason=; event=E341
- Proposal P67: actor=Iri [P3]; Committed; reason=; event=E342
- Proposal P68: actor=Gala [P4]; Committed; reason=; event=E343

### Semantic events
- E328 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E329 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E330 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E331 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E332 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E333 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E334 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E335 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E336 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E337 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E338 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E339 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E340 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:1->2:Gift]
- E341 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:2->3:Gift]
- E342 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:0->1:Gift]
- E343 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:1->2:Gift]
- E344 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E345 r17: AttitudeComposition; participants=[P1,P4]; detail=98->100; fallback=False
- E346 r18: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E347 r19: AttitudeComposition; participants=[P3,P2]; detail=51->61; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=2; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 18

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=138 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P69: actor=Hani [P1]; Committed; reason=; event=E359
- Proposal P70: actor=Luma [P2]; Committed; reason=; event=E360
- Proposal P71: actor=Iri [P3]; Committed; reason=; event=E361
- Proposal P72: actor=Gala [P4]; Committed; reason=; event=E362

### Semantic events
- E348 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E349 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E350 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E351 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E352 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E353 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E354 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E355 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E356 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E357 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E358 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E359 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:1->2:Gift]
- E360 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E361 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:0->1:Gift]
- E362 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:1->0:Gift; P1:1->2:Gift]
- E363 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E364 r16: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E365 r17: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=7; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=1; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=0; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 19

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=14 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P73: actor=Hani [P1]; Committed; reason=; event=E377
- Proposal P74: actor=Luma [P2]; Committed; reason=; event=E378
- Proposal P75: actor=Iri [P3]; Committed; reason=; event=E379
- Proposal P76: actor=Gala [P4]; InvalidatedAtResolution; reason=InsufficientAvailableGrain; event=E380

### Semantic events
- E366 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E367 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E368 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E369 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E370 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E371 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E372 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E373 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E374 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E375 r9: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E376 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E377 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=True material=[P1:1->0:Gift; P3:0->1:Gift]
- E378 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:6->5:Gift; P3:1->2:Gift]
- E379 r13: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:2->6:FarmSource]
- E380 r14: InvalidatedAtResolution; participants=[P4,P1]; detail=InsufficientAvailableGrain; fallback=True
- E381 r15: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E382 r16: AttitudeComposition; participants=[P3,P2]; detail=61->71; fallback=False

### Stable state
- Hani [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=6; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 20

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/Feasibility: none; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=10 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P77: actor=Hani [P1]; Committed; reason=; event=E407
- Proposal P78: actor=Luma [P2]; Committed; reason=; event=E408
- Proposal P79: actor=Iri [P3]; Committed; reason=; event=E409
- Proposal P80: actor=Gala [P4]; Unable; reason=InsufficientAvailableGrain; event=E406

### Semantic events
- E383 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E384 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E385 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E386 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E387 r4: AttitudeDecay; participants=[P1,P2]; detail=11->9; fallback=False
- E388 r5: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E389 r6: AttitudeDecay; participants=[P1,P4]; detail=100->98; fallback=False
- E390 r7: AttitudeDecay; participants=[P2,P1]; detail=-25->-24; fallback=False
- E391 r8: AttitudeDecay; participants=[P2,P3]; detail=7->5; fallback=False
- E392 r9: AttitudeDecay; participants=[P2,P4]; detail=0->0; fallback=False
- E393 r10: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E394 r11: AttitudeDecay; participants=[P3,P2]; detail=71->69; fallback=False
- E395 r12: AttitudeDecay; participants=[P3,P4]; detail=-13->-12; fallback=False
- E396 r13: AttitudeDecay; participants=[P4,P1]; detail=69->67; fallback=False
- E397 r14: AttitudeDecay; participants=[P4,P2]; detail=16->14; fallback=False
- E398 r15: AttitudeDecay; participants=[P4,P3]; detail=31->29; fallback=False
- E399 r16: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E400 r17: Response; participants=[P2]; detail=Accept; fallback=False
- E401 r18: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E402 r19: Response; participants=[P3]; detail=Accept; fallback=False
- E403 r20: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E404 r21: Response; participants=[P1]; detail=Accept; fallback=False
- E405 r22: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E406 r23: Unable; participants=[P4,P1]; detail=InsufficientAvailableGrain; fallback=False
- E407 r24: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:4->3:Help; P1:0->1:Help]
- E408 r25: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:5->6:Gift]
- E409 r26: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:6->5:Gift; P1:1->2:Gift]
- E410 r27: AttitudeComposition; participants=[P1,P2]; detail=9->19; fallback=False
- E411 r28: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E412 r29: AttitudeComposition; participants=[P3,P2]; detail=69->79; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=2; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=5; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 21

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P81: actor=Hani [P1]; Committed; reason=; event=E424
- Proposal P82: actor=Luma [P2]; Committed; reason=; event=E425
- Proposal P83: actor=Iri [P3]; Committed; reason=; event=E426
- Proposal P84: actor=Gala [P4]; Committed; reason=; event=E427

### Semantic events
- E413 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E414 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E415 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E416 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E417 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E418 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E419 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E420 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E421 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E422 r9: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E423 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E424 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=True material=[P1:1->0:Gift; P3:4->5:Gift]
- E425 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:1->5:FarmSource]
- E426 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=True material=[P3:5->4:Gift; P1:0->1:Gift]
- E427 r14: Help; participants=[P1,P4]; detail=RequestGiftOrHelp(1,1); fallback=True material=[P1:1->0:Help; P4:0->1:Help]
- E428 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E429 r16: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False
- E430 r17: AttitudeComposition; participants=[P4,P1]; detail=67->77; fallback=False

### Stable state
- Hani [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=4; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 22

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=10 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P85: actor=Hani [P1]; Committed; reason=; event=E442
- Proposal P86: actor=Luma [P2]; Committed; reason=; event=E443
- Proposal P87: actor=Iri [P3]; Committed; reason=; event=E444
- Proposal P88: actor=Gala [P4]; Committed; reason=; event=E445

### Semantic events
- E431 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E432 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E433 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E434 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E435 r4: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E436 r5: Response; participants=[P2]; detail=Accept; fallback=False
- E437 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E438 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E439 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E440 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E441 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E442 r11: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:4->3:Help; P1:0->1:Help]
- E443 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:3->4:Gift]
- E444 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:1->2:Gift]
- E445 r14: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E446 r15: AttitudeComposition; participants=[P1,P2]; detail=19->29; fallback=False
- E447 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E448 r17: AttitudeComposition; participants=[P3,P2]; detail=79->89; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=2; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=3; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 23

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=154 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P89: actor=Hani [P1]; Committed; reason=; event=E460
- Proposal P90: actor=Luma [P2]; Committed; reason=; event=E461
- Proposal P91: actor=Iri [P3]; Committed; reason=; event=E462
- Proposal P92: actor=Gala [P4]; Committed; reason=; event=E463

### Semantic events
- E449 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E450 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E451 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E452 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E453 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E454 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E455 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E456 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E457 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E458 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E459 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E460 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:2->3:Gift]
- E461 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:1->5:FarmSource]
- E462 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:0->1:Gift]
- E463 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:1->2:Gift]
- E464 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E465 r16: AttitudeComposition; participants=[P1,P4]; detail=98->100; fallback=False
- E466 r17: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=2; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 24

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=10 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=154 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P93: actor=Hani [P1]; Committed; reason=; event=E479
- Proposal P94: actor=Luma [P2]; Committed; reason=; event=E480
- Proposal P95: actor=Iri [P3]; Committed; reason=; event=E481
- Proposal P96: actor=Gala [P4]; Committed; reason=; event=E482

### Semantic events
- E467 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E468 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E469 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E470 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E471 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E472 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E473 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E474 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E475 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E476 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E477 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E478 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E479 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:1->2:Gift]
- E480 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:2->3:Gift]
- E481 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:0->1:Gift]
- E482 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:1->0:Gift; P1:1->2:Gift]
- E483 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E484 r17: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E485 r18: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E486 r19: AttitudeComposition; participants=[P3,P2]; detail=89->99; fallback=False

### Stable state
- Hani [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=2; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=0; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 25

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P97: actor=Hani [P1]; Committed; reason=; event=E510
- Proposal P98: actor=Luma [P2]; Committed; reason=; event=E511
- Proposal P99: actor=Iri [P3]; Committed; reason=; event=E512
- Proposal P100: actor=Gala [P4]; Committed; reason=; event=E513

### Semantic events
- E487 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E488 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E489 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E490 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E491 r4: AttitudeDecay; participants=[P1,P2]; detail=29->27; fallback=False
- E492 r5: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E493 r6: AttitudeDecay; participants=[P1,P4]; detail=100->98; fallback=False
- E494 r7: AttitudeDecay; participants=[P2,P1]; detail=-24->-23; fallback=False
- E495 r8: AttitudeDecay; participants=[P2,P3]; detail=5->3; fallback=False
- E496 r9: AttitudeDecay; participants=[P2,P4]; detail=0->0; fallback=False
- E497 r10: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E498 r11: AttitudeDecay; participants=[P3,P2]; detail=99->97; fallback=False
- E499 r12: AttitudeDecay; participants=[P3,P4]; detail=-12->-11; fallback=False
- E500 r13: AttitudeDecay; participants=[P4,P1]; detail=77->75; fallback=False
- E501 r14: AttitudeDecay; participants=[P4,P2]; detail=14->12; fallback=False
- E502 r15: AttitudeDecay; participants=[P4,P3]; detail=29->27; fallback=False
- E503 r16: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E504 r17: Response; participants=[P3]; detail=Accept; fallback=False
- E505 r18: Proposal; participants=[P2]; detail=Farm; fallback=False
- E506 r19: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E507 r20: Response; participants=[P1]; detail=Accept; fallback=False
- E508 r21: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E509 r22: Response; participants=[P1]; detail=Accept; fallback=False
- E510 r23: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=True material=[P1:1->0:Gift; P3:1->2:Gift]
- E511 r24: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:2->6:FarmSource]
- E512 r25: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=True material=[P3:2->1:Gift; P1:0->1:Gift]
- E513 r26: Help; participants=[P1,P4]; detail=RequestGiftOrHelp(1,1); fallback=True material=[P1:1->0:Help; P4:0->1:Help]
- E514 r27: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E515 r28: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False
- E516 r29: AttitudeComposition; participants=[P4,P1]; detail=75->85; fallback=False

### Stable state
- Hani [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=1; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 26

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=6 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P101: actor=Hani [P1]; Committed; reason=; event=E527
- Proposal P102: actor=Luma [P2]; Committed; reason=; event=E528
- Proposal P103: actor=Iri [P3]; Committed; reason=; event=E529
- Proposal P104: actor=Gala [P4]; Committed; reason=; event=E530

### Semantic events
- E517 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E518 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E519 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E520 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E521 r4: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E522 r5: Response; participants=[P2]; detail=Accept; fallback=False
- E523 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E524 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E525 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E526 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E527 r10: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:5->4:Help; P1:0->1:Help]
- E528 r11: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:0->1:Gift]
- E529 r12: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E530 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E531 r14: AttitudeComposition; participants=[P1,P2]; detail=27->37; fallback=False
- E532 r15: AttitudeComposition; participants=[P3,P2]; detail=97->100; fallback=False

### Stable state
- Hani [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=5; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 27

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=170 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P105: actor=Hani [P1]; Committed; reason=; event=E543
- Proposal P106: actor=Luma [P2]; Committed; reason=; event=E544
- Proposal P107: actor=Iri [P3]; Committed; reason=; event=E545
- Proposal P108: actor=Gala [P4]; Committed; reason=; event=E546

### Semantic events
- E533 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E534 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E535 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E536 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E537 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E538 r5: Proposal; participants=[P2]; detail=Farm; fallback=False
- E539 r6: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E540 r7: Response; participants=[P1]; detail=Accept; fallback=False
- E541 r8: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E542 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E543 r10: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E544 r11: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:2->6:FarmSource]
- E545 r12: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:4->5:Gift]
- E546 r13: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:5->6:Gift]
- E547 r14: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E548 r15: AttitudeComposition; participants=[P1,P4]; detail=98->100; fallback=False

### Stable state
- Hani [P1]: grain=6; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=3; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 28

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=6 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=170 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P109: actor=Hani [P1]; Committed; reason=; event=E561
- Proposal P110: actor=Luma [P2]; Committed; reason=; event=E562
- Proposal P111: actor=Iri [P3]; Committed; reason=; event=E563
- Proposal P112: actor=Gala [P4]; Committed; reason=; event=E564

### Semantic events
- E549 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E550 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E551 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E552 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E553 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E554 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E555 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E556 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E557 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E558 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E559 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E560 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E561 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:5->4:Gift; P3:2->3:Gift]
- E562 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:3->4:Gift]
- E563 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:4->5:Gift]
- E564 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:1->0:Gift; P1:5->6:Gift]
- E565 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E566 r17: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E567 r18: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E568 r19: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False

### Stable state
- Hani [P1]: grain=6; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=3; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=0; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 29

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P113: actor=Hani [P1]; Committed; reason=; event=E580
- Proposal P114: actor=Luma [P2]; Committed; reason=; event=E581
- Proposal P115: actor=Iri [P3]; Committed; reason=; event=E582
- Proposal P116: actor=Gala [P4]; Committed; reason=; event=E583

### Semantic events
- E569 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E570 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E571 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E572 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E573 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E574 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E575 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E576 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E577 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E578 r9: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E579 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E580 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:5->4:Gift; P3:2->3:Gift]
- E581 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E582 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:4->5:Gift]
- E583 r14: Help; participants=[P1,P4]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:5->4:Help; P4:0->1:Help]
- E584 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E585 r16: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E586 r17: AttitudeComposition; participants=[P4,P1]; detail=85->95; fallback=False

### Stable state
- Hani [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=7; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=2; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 30

### Decisions
- Hani [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=2 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iri [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P117: actor=Hani [P1]; Committed; reason=; event=E610
- Proposal P118: actor=Luma [P2]; Committed; reason=; event=E611
- Proposal P119: actor=Iri [P3]; Committed; reason=; event=E612
- Proposal P120: actor=Gala [P4]; Committed; reason=; event=E613

### Semantic events
- E587 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E588 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E589 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E590 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E591 r4: AttitudeDecay; participants=[P1,P2]; detail=37->35; fallback=False
- E592 r5: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E593 r6: AttitudeDecay; participants=[P1,P4]; detail=100->98; fallback=False
- E594 r7: AttitudeDecay; participants=[P2,P1]; detail=-23->-22; fallback=False
- E595 r8: AttitudeDecay; participants=[P2,P3]; detail=3->1; fallback=False
- E596 r9: AttitudeDecay; participants=[P2,P4]; detail=0->0; fallback=False
- E597 r10: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E598 r11: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E599 r12: AttitudeDecay; participants=[P3,P4]; detail=-11->-10; fallback=False
- E600 r13: AttitudeDecay; participants=[P4,P1]; detail=95->93; fallback=False
- E601 r14: AttitudeDecay; participants=[P4,P2]; detail=12->10; fallback=False
- E602 r15: AttitudeDecay; participants=[P4,P3]; detail=27->25; fallback=False
- E603 r16: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E604 r17: Response; participants=[P3]; detail=Accept; fallback=False
- E605 r18: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E606 r19: Response; participants=[P3]; detail=Accept; fallback=False
- E607 r20: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E608 r21: Response; participants=[P1]; detail=Accept; fallback=False
- E609 r22: Proposal; participants=[P4]; detail=Farm; fallback=False
- E610 r23: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:1->2:Gift]
- E611 r24: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:6->5:Gift; P3:2->3:Gift]
- E612 r25: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:2->3:Gift]
- E613 r26: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E614 r27: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E615 r28: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False
- E616 r29: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False

### Stable state
- Hani [P1]: grain=3; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Iri [P3]: grain=2; NeedsGrain=False; dwelling=D1
- Gala [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Stop

- Horizon:30
