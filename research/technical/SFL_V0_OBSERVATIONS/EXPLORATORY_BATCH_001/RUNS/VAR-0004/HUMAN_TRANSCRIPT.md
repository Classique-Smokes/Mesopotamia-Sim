# Birth Run 001 — Mechanical Transcript

Generated mechanically from production public simulation surfaces. No interpretation is included.

## Declared initial state
- P1 Tari: sex=Male; grain=4; NeedsGrain=False; dwelling=D3
- P2 Rima: sex=Male; grain=6; NeedsGrain=False; dwelling=D3
- P3 Pala: sex=Male; grain=2; NeedsGrain=False; dwelling=D1
- P4 Nadi: sex=Female; grain=5; NeedsGrain=False; dwelling=D2

## Cycle 1

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=30 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=88 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P1: actor=Tari [P1]; Committed; reason=; event=E11
- Proposal P2: actor=Rima [P2]; Committed; reason=; event=E12
- Proposal P3: actor=Pala [P3]; Committed; reason=; event=E13
- Proposal P4: actor=Nadi [P4]; Committed; reason=; event=E14

### Semantic events
- E1 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E2 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E3 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E4 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E5 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E6 r5: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E7 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E8 r7: Proposal; participants=[P3]; detail=Farm; fallback=False
- E9 r8: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E10 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E11 r10: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:3->7:FarmSource]
- E12 r11: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:1->2:Gift]
- E13 r12: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:2->6:FarmSource]
- E14 r13: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:7->8:Gift]
- E15 r14: AttitudeComposition; participants=[P1,P4]; detail=10->20; fallback=False
- E16 r15: AttitudeComposition; participants=[P3,P2]; detail=-31->-21; fallback=False

### Stable state
- Tari [P1]: grain=8; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=6; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 2

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=40 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=0 terms=Farm { }; TechnicalFallback=True
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=88 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P5: actor=Tari [P1]; Committed; reason=; event=E27
- Proposal P6: actor=Rima [P2]; Committed; reason=; event=E28
- Proposal P7: actor=Pala [P3]; Committed; reason=; event=E29
- Proposal P8: actor=Nadi [P4]; Committed; reason=; event=E30

### Semantic events
- E17 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:8->7:ConsumptionSink]
- E18 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E19 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E20 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E21 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E22 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E23 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E24 r7: Proposal; participants=[P3]; detail=Farm; fallback=False
- E25 r8: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E26 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E27 r10: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:7->6:Gift; P4:2->3:Gift]
- E28 r11: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E29 r12: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:5->9:FarmSource]
- E30 r13: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:6->7:Gift]
- E31 r14: AttitudeComposition; participants=[P1,P4]; detail=20->30; fallback=False
- E32 r15: AttitudeComposition; participants=[P4,P1]; detail=44->54; fallback=False

### Stable state
- Tari [P1]: grain=7; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=7; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=9; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 3

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=60 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=30 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=0 terms=Farm { }; TechnicalFallback=True
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=108 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P9: actor=Tari [P1]; Committed; reason=; event=E44
- Proposal P10: actor=Rima [P2]; Committed; reason=; event=E45
- Proposal P11: actor=Pala [P3]; Committed; reason=; event=E46
- Proposal P12: actor=Nadi [P4]; Committed; reason=; event=E47

### Semantic events
- E33 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:7->6:ConsumptionSink]
- E34 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E35 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:9->8:ConsumptionSink]
- E36 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E37 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E38 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E39 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E40 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E41 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E42 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E43 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E44 r11: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:6->5:Gift; P4:1->2:Gift]
- E45 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:6->5:Gift; P3:8->9:Gift]
- E46 r13: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:9->13:FarmSource]
- E47 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:5->6:Gift]
- E48 r15: AttitudeComposition; participants=[P1,P4]; detail=30->40; fallback=False
- E49 r16: AttitudeComposition; participants=[P3,P2]; detail=-21->-11; fallback=False
- E50 r17: AttitudeComposition; participants=[P4,P1]; detail=54->64; fallback=False

### Stable state
- Tari [P1]: grain=6; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=13; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 4

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=80 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=30 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=0 terms=Farm { }; TechnicalFallback=True
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P13: actor=Tari [P1]; Committed; reason=; event=E61
- Proposal P14: actor=Rima [P2]; Committed; reason=; event=E62
- Proposal P15: actor=Pala [P3]; Committed; reason=; event=E63
- Proposal P16: actor=Nadi [P4]; Committed; reason=; event=E64

### Semantic events
- E51 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E52 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E53 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:13->12:ConsumptionSink]
- E54 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E55 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E56 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E57 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E58 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E59 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E60 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E61 r10: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:5->4:Gift; P4:0->1:Gift]
- E62 r11: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:12->13:Gift]
- E63 r12: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:13->17:FarmSource]
- E64 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E65 r14: AttitudeComposition; participants=[P3,P2]; detail=-11->-1; fallback=False
- E66 r15: AttitudeComposition; participants=[P4,P1]; detail=64->74; fallback=False

### Stable state
- Tari [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=17; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=5; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 5

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=76 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=0 terms=Farm { }; TechnicalFallback=True
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=144 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P17: actor=Tari [P1]; Committed; reason=; event=E85
- Proposal P18: actor=Rima [P2]; Committed; reason=; event=E86
- Proposal P19: actor=Pala [P3]; Committed; reason=; event=E87
- Proposal P20: actor=Nadi [P4]; Committed; reason=; event=E88

### Semantic events
- E67 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E68 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E69 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:17->16:ConsumptionSink]
- E70 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E71 r4: AttitudeDecay; participants=[P1,P2]; detail=1->0; fallback=False
- E72 r5: AttitudeDecay; participants=[P1,P4]; detail=40->38; fallback=False
- E73 r6: AttitudeDecay; participants=[P2,P1]; detail=-23->-22; fallback=False
- E74 r7: AttitudeDecay; participants=[P2,P3]; detail=15->13; fallback=False
- E75 r8: AttitudeDecay; participants=[P3,P2]; detail=-1->0; fallback=False
- E76 r9: AttitudeDecay; participants=[P3,P4]; detail=-2->-1; fallback=False
- E77 r10: AttitudeDecay; participants=[P4,P1]; detail=74->72; fallback=False
- E78 r11: AttitudeDecay; participants=[P4,P3]; detail=14->12; fallback=False
- E79 r12: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E80 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E81 r14: Proposal; participants=[P2]; detail=Farm; fallback=False
- E82 r15: Proposal; participants=[P3]; detail=Farm; fallback=False
- E83 r16: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E84 r17: Response; participants=[P1]; detail=Accept; fallback=False
- E85 r18: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:3->2:Gift; P4:4->5:Gift]
- E86 r19: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:2->6:FarmSource]
- E87 r20: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:16->20:FarmSource]
- E88 r21: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:5->4:Gift; P1:2->3:Gift]
- E89 r22: AttitudeComposition; participants=[P1,P4]; detail=38->48; fallback=False
- E90 r23: AttitudeComposition; participants=[P4,P1]; detail=72->82; fallback=False

### Stable state
- Tari [P1]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=6; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=20; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 6

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=96 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=26 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=0 terms=Farm { }; TechnicalFallback=True
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=164 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P21: actor=Tari [P1]; Committed; reason=; event=E102
- Proposal P22: actor=Rima [P2]; Committed; reason=; event=E103
- Proposal P23: actor=Pala [P3]; Committed; reason=; event=E104
- Proposal P24: actor=Nadi [P4]; Committed; reason=; event=E105

### Semantic events
- E91 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E92 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E93 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:20->19:ConsumptionSink]
- E94 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E95 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E96 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E97 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E98 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E99 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E100 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E101 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E102 r11: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:2->1:Gift; P4:3->4:Gift]
- E103 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:19->20:Gift]
- E104 r13: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:20->24:FarmSource]
- E105 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:1->2:Gift]
- E106 r15: AttitudeComposition; participants=[P1,P4]; detail=48->58; fallback=False
- E107 r16: AttitudeComposition; participants=[P3,P2]; detail=0->10; fallback=False
- E108 r17: AttitudeComposition; participants=[P4,P1]; detail=82->92; fallback=False

### Stable state
- Tari [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=24; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 7

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=116 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=20 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=184 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P25: actor=Tari [P1]; Committed; reason=; event=E120
- Proposal P26: actor=Rima [P2]; Committed; reason=; event=E121
- Proposal P27: actor=Pala [P3]; Committed; reason=; event=E122
- Proposal P28: actor=Nadi [P4]; Committed; reason=; event=E123

### Semantic events
- E109 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E110 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E111 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:24->23:ConsumptionSink]
- E112 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E113 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E114 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E115 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E116 r7: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E117 r8: Response; participants=[P2]; detail=Accept; fallback=False
- E118 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E119 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E120 r11: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:2->3:Gift]
- E121 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E122 r13: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:23->22:Gift; P2:7->8:Gift]
- E123 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:0->1:Gift]
- E124 r15: AttitudeComposition; participants=[P1,P4]; detail=58->68; fallback=False
- E125 r16: AttitudeComposition; participants=[P2,P3]; detail=13->23; fallback=False
- E126 r17: AttitudeComposition; participants=[P4,P1]; detail=92->100; fallback=False

### Stable state
- Tari [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=8; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=22; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 8

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=46 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=20 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P29: actor=Tari [P1]; Committed; reason=; event=E138
- Proposal P30: actor=Rima [P2]; Committed; reason=; event=E139
- Proposal P31: actor=Pala [P3]; Committed; reason=; event=E140
- Proposal P32: actor=Nadi [P4]; Committed; reason=; event=E141

### Semantic events
- E127 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E128 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:8->7:ConsumptionSink]
- E129 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:22->21:ConsumptionSink]
- E130 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E131 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E132 r5: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E133 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E134 r7: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E135 r8: Response; participants=[P2]; detail=Accept; fallback=False
- E136 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E137 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E138 r11: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E139 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:7->6:Gift; P3:21->22:Gift]
- E140 r13: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:22->21:Gift; P2:6->7:Gift]
- E141 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:1->0:Gift; P1:4->5:Gift]
- E142 r15: AttitudeComposition; participants=[P1,P4]; detail=68->78; fallback=False
- E143 r16: AttitudeComposition; participants=[P2,P3]; detail=23->33; fallback=False
- E144 r17: AttitudeComposition; participants=[P3,P2]; detail=10->20; fallback=False

### Stable state
- Tari [P1]: grain=5; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=7; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=21; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=0; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 9

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=156 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=66 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=40 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P33: actor=Tari [P1]; Committed; reason=; event=E157
- Proposal P34: actor=Rima [P2]; Committed; reason=; event=E158
- Proposal P35: actor=Pala [P3]; Committed; reason=; event=E159
- Proposal P36: actor=Nadi [P4]; Committed; reason=; event=E160

### Semantic events
- E145 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E146 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E147 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:21->20:ConsumptionSink]
- E148 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E149 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E150 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E151 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E152 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E153 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E154 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E155 r10: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E156 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E157 r12: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:4->3:Gift; P4:0->1:Gift]
- E158 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:6->5:Gift; P3:20->21:Gift]
- E159 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:21->20:Gift; P2:5->6:Gift]
- E160 r15: Help; participants=[P1,P4]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:3->2:Help; P4:1->2:Help]
- E161 r16: AttitudeComposition; participants=[P2,P3]; detail=33->43; fallback=False
- E162 r17: AttitudeComposition; participants=[P3,P2]; detail=20->30; fallback=False
- E163 r18: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=6; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=20; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 10

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=152 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=82 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=56 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P37: actor=Tari [P1]; Committed; reason=; event=E184
- Proposal P38: actor=Rima [P2]; Committed; reason=; event=E185
- Proposal P39: actor=Pala [P3]; Committed; reason=; event=E186
- Proposal P40: actor=Nadi [P4]; Committed; reason=; event=E187

### Semantic events
- E164 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E165 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E166 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:20->19:ConsumptionSink]
- E167 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E168 r4: AttitudeDecay; participants=[P1,P2]; detail=0->0; fallback=False
- E169 r5: AttitudeDecay; participants=[P1,P4]; detail=78->76; fallback=False
- E170 r6: AttitudeDecay; participants=[P2,P1]; detail=-22->-21; fallback=False
- E171 r7: AttitudeDecay; participants=[P2,P3]; detail=43->41; fallback=False
- E172 r8: AttitudeDecay; participants=[P3,P2]; detail=30->28; fallback=False
- E173 r9: AttitudeDecay; participants=[P3,P4]; detail=-1->0; fallback=False
- E174 r10: AttitudeDecay; participants=[P4,P1]; detail=100->98; fallback=False
- E175 r11: AttitudeDecay; participants=[P4,P3]; detail=12->10; fallback=False
- E176 r12: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E177 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E178 r14: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E179 r15: Response; participants=[P3]; detail=Accept; fallback=False
- E180 r16: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E181 r17: Response; participants=[P2]; detail=Accept; fallback=False
- E182 r18: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E183 r19: Response; participants=[P1]; detail=Accept; fallback=False
- E184 r20: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:1->2:Gift]
- E185 r21: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:19->20:Gift]
- E186 r22: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:20->19:Gift; P2:4->5:Gift]
- E187 r23: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:0->1:Gift]
- E188 r24: AttitudeComposition; participants=[P1,P4]; detail=76->86; fallback=False
- E189 r25: AttitudeComposition; participants=[P2,P3]; detail=41->51; fallback=False
- E190 r26: AttitudeComposition; participants=[P3,P2]; detail=28->38; fallback=False
- E191 r27: AttitudeComposition; participants=[P4,P1]; detail=98->100; fallback=False

### Stable state
- Tari [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=19; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 11

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=102 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=76 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P41: actor=Tari [P1]; Committed; reason=; event=E202
- Proposal P42: actor=Rima [P2]; Committed; reason=; event=E203
- Proposal P43: actor=Pala [P3]; Committed; reason=; event=E204
- Proposal P44: actor=Nadi [P4]; Committed; reason=; event=E205

### Semantic events
- E192 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E193 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E194 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:19->18:ConsumptionSink]
- E195 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E196 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E197 r5: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E198 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E199 r7: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E200 r8: Response; participants=[P2]; detail=Accept; fallback=False
- E201 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E202 r10: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E203 r11: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:18->19:Gift]
- E204 r12: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:19->18:Gift; P2:3->4:Gift]
- E205 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E206 r14: AttitudeComposition; participants=[P2,P3]; detail=51->61; fallback=False
- E207 r15: AttitudeComposition; participants=[P3,P2]; detail=38->48; fallback=False

### Stable state
- Tari [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=18; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 12

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=172 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=122 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=96 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P45: actor=Tari [P1]; Committed; reason=; event=E220
- Proposal P46: actor=Rima [P2]; Committed; reason=; event=E221
- Proposal P47: actor=Pala [P3]; Committed; reason=; event=E222
- Proposal P48: actor=Nadi [P4]; Committed; reason=; event=E223

### Semantic events
- E208 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E209 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E210 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:18->17:ConsumptionSink]
- E211 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E212 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E213 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E214 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E215 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E216 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E217 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E218 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E219 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E220 r12: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:3->2:Gift; P4:3->4:Gift]
- E221 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:17->18:Gift]
- E222 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:18->17:Gift; P2:2->3:Gift]
- E223 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:2->3:Gift]
- E224 r16: AttitudeComposition; participants=[P1,P4]; detail=86->96; fallback=False
- E225 r17: AttitudeComposition; participants=[P2,P3]; detail=61->71; fallback=False
- E226 r18: AttitudeComposition; participants=[P3,P2]; detail=48->58; fallback=False
- E227 r19: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=17; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 13

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=192 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=142 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=116 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P49: actor=Tari [P1]; Committed; reason=; event=E240
- Proposal P50: actor=Rima [P2]; Committed; reason=; event=E241
- Proposal P51: actor=Pala [P3]; Committed; reason=; event=E242
- Proposal P52: actor=Nadi [P4]; Committed; reason=; event=E243

### Semantic events
- E228 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E229 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E230 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:17->16:ConsumptionSink]
- E231 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E232 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E233 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E234 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E235 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E236 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E237 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E238 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E239 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E240 r12: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:2->1:Gift; P4:2->3:Gift]
- E241 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:16->17:Gift]
- E242 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:17->16:Gift; P2:1->2:Gift]
- E243 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:1->2:Gift]
- E244 r16: AttitudeComposition; participants=[P1,P4]; detail=96->100; fallback=False
- E245 r17: AttitudeComposition; participants=[P2,P3]; detail=71->81; fallback=False
- E246 r18: AttitudeComposition; participants=[P3,P2]; detail=58->68; fallback=False
- E247 r19: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=16; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 14

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=162 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=136 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P53: actor=Tari [P1]; Committed; reason=; event=E260
- Proposal P54: actor=Rima [P2]; Committed; reason=; event=E261
- Proposal P55: actor=Pala [P3]; Committed; reason=; event=E262
- Proposal P56: actor=Nadi [P4]; Committed; reason=; event=E263

### Semantic events
- E248 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E249 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E250 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:16->15:ConsumptionSink]
- E251 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E252 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E253 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E254 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E255 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E256 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E257 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E258 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E259 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E260 r12: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:1->2:Gift]
- E261 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:1->0:Gift; P3:15->16:Gift]
- E262 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:16->15:Gift; P2:0->1:Gift]
- E263 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:0->1:Gift]
- E264 r16: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E265 r17: AttitudeComposition; participants=[P2,P3]; detail=81->91; fallback=False
- E266 r18: AttitudeComposition; participants=[P3,P2]; detail=68->78; fallback=False
- E267 r19: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=15; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 15

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=152 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P57: actor=Tari [P1]; Committed; reason=; event=E285
- Proposal P58: actor=Rima [P2]; Committed; reason=; event=E286
- Proposal P59: actor=Pala [P3]; Committed; reason=; event=E287
- Proposal P60: actor=Nadi [P4]; Committed; reason=; event=E288

### Semantic events
- E268 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E269 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E270 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:15->14:ConsumptionSink]
- E271 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E272 r4: AttitudeDecay; participants=[P1,P2]; detail=0->0; fallback=False
- E273 r5: AttitudeDecay; participants=[P1,P4]; detail=100->98; fallback=False
- E274 r6: AttitudeDecay; participants=[P2,P1]; detail=-21->-20; fallback=False
- E275 r7: AttitudeDecay; participants=[P2,P3]; detail=91->89; fallback=False
- E276 r8: AttitudeDecay; participants=[P3,P2]; detail=78->76; fallback=False
- E277 r9: AttitudeDecay; participants=[P3,P4]; detail=0->0; fallback=False
- E278 r10: AttitudeDecay; participants=[P4,P1]; detail=100->98; fallback=False
- E279 r11: AttitudeDecay; participants=[P4,P3]; detail=10->8; fallback=False
- E280 r12: Proposal; participants=[P1]; detail=Farm; fallback=False
- E281 r13: Proposal; participants=[P2]; detail=Farm; fallback=False
- E282 r14: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E283 r15: Response; participants=[P2]; detail=Accept; fallback=False
- E284 r16: Proposal; participants=[P4]; detail=Farm; fallback=False
- E285 r17: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E286 r18: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E287 r19: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:14->13:Gift; P2:4->5:Gift]
- E288 r20: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E289 r21: AttitudeComposition; participants=[P2,P3]; detail=89->99; fallback=False

### Stable state
- Tari [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=13; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 16

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=198 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=152 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P61: actor=Tari [P1]; Committed; reason=; event=E302
- Proposal P62: actor=Rima [P2]; Committed; reason=; event=E303
- Proposal P63: actor=Pala [P3]; Committed; reason=; event=E304
- Proposal P64: actor=Nadi [P4]; Committed; reason=; event=E305

### Semantic events
- E290 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E291 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E292 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:13->12:ConsumptionSink]
- E293 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E294 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E295 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E296 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E297 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E298 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E299 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E300 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E301 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E302 r12: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:3->2:Gift; P4:3->4:Gift]
- E303 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:12->13:Gift]
- E304 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:13->12:Gift; P2:3->4:Gift]
- E305 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:2->3:Gift]
- E306 r16: AttitudeComposition; participants=[P1,P4]; detail=98->100; fallback=False
- E307 r17: AttitudeComposition; participants=[P2,P3]; detail=99->100; fallback=False
- E308 r18: AttitudeComposition; participants=[P3,P2]; detail=76->86; fallback=False
- E309 r19: AttitudeComposition; participants=[P4,P1]; detail=98->100; fallback=False

### Stable state
- Tari [P1]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=12; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 17

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=172 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P65: actor=Tari [P1]; Committed; reason=; event=E322
- Proposal P66: actor=Rima [P2]; Committed; reason=; event=E323
- Proposal P67: actor=Pala [P3]; Committed; reason=; event=E324
- Proposal P68: actor=Nadi [P4]; Committed; reason=; event=E325

### Semantic events
- E310 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E311 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E312 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:12->11:ConsumptionSink]
- E313 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E314 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E315 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E316 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E317 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E318 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E319 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E320 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E321 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E322 r12: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:2->1:Gift; P4:2->3:Gift]
- E323 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:11->12:Gift]
- E324 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:12->11:Gift; P2:2->3:Gift]
- E325 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:1->2:Gift]
- E326 r16: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E327 r17: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E328 r18: AttitudeComposition; participants=[P3,P2]; detail=86->96; fallback=False
- E329 r19: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=11; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 18

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=192 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P69: actor=Tari [P1]; Committed; reason=; event=E342
- Proposal P70: actor=Rima [P2]; Committed; reason=; event=E343
- Proposal P71: actor=Pala [P3]; Committed; reason=; event=E344
- Proposal P72: actor=Nadi [P4]; Committed; reason=; event=E345

### Semantic events
- E330 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E331 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E332 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:11->10:ConsumptionSink]
- E333 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E334 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E335 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E336 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E337 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E338 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E339 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E340 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E341 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E342 r12: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:1->2:Gift]
- E343 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:10->11:Gift]
- E344 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:11->10:Gift; P2:1->2:Gift]
- E345 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:0->1:Gift]
- E346 r16: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E347 r17: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E348 r18: AttitudeComposition; participants=[P3,P2]; detail=96->100; fallback=False
- E349 r19: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=10; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 19

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P73: actor=Tari [P1]; Committed; reason=; event=E360
- Proposal P74: actor=Rima [P2]; Committed; reason=; event=E361
- Proposal P75: actor=Pala [P3]; Committed; reason=; event=E362
- Proposal P76: actor=Nadi [P4]; Committed; reason=; event=E363

### Semantic events
- E350 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E351 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E352 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:10->9:ConsumptionSink]
- E353 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E354 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E355 r5: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E356 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E357 r7: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E358 r8: Response; participants=[P2]; detail=Accept; fallback=False
- E359 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E360 r10: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E361 r11: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:1->0:Gift; P3:9->10:Gift]
- E362 r12: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:10->9:Gift; P2:0->1:Gift]
- E363 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E364 r14: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E365 r15: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=9; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 20

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P77: actor=Tari [P1]; Committed; reason=; event=E385
- Proposal P78: actor=Rima [P2]; Committed; reason=; event=E386
- Proposal P79: actor=Pala [P3]; Committed; reason=; event=E387
- Proposal P80: actor=Nadi [P4]; Committed; reason=; event=E388

### Semantic events
- E366 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E367 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E368 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:9->8:ConsumptionSink]
- E369 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E370 r4: AttitudeDecay; participants=[P1,P2]; detail=0->0; fallback=False
- E371 r5: AttitudeDecay; participants=[P1,P4]; detail=100->98; fallback=False
- E372 r6: AttitudeDecay; participants=[P2,P1]; detail=-20->-19; fallback=False
- E373 r7: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E374 r8: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E375 r9: AttitudeDecay; participants=[P3,P4]; detail=0->0; fallback=False
- E376 r10: AttitudeDecay; participants=[P4,P1]; detail=100->98; fallback=False
- E377 r11: AttitudeDecay; participants=[P4,P3]; detail=8->6; fallback=False
- E378 r12: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E379 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E380 r14: Proposal; participants=[P2]; detail=Farm; fallback=False
- E381 r15: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E382 r16: Response; participants=[P2]; detail=Accept; fallback=False
- E383 r17: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E384 r18: Response; participants=[P1]; detail=Accept; fallback=False
- E385 r19: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:3->2:Gift; P4:3->4:Gift]
- E386 r20: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E387 r21: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:8->7:Gift; P2:4->5:Gift]
- E388 r22: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:2->3:Gift]
- E389 r23: AttitudeComposition; participants=[P1,P4]; detail=98->100; fallback=False
- E390 r24: AttitudeComposition; participants=[P2,P3]; detail=98->100; fallback=False
- E391 r25: AttitudeComposition; participants=[P4,P1]; detail=98->100; fallback=False

### Stable state
- Tari [P1]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=7; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 21

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P81: actor=Tari [P1]; Committed; reason=; event=E404
- Proposal P82: actor=Rima [P2]; Committed; reason=; event=E405
- Proposal P83: actor=Pala [P3]; Committed; reason=; event=E406
- Proposal P84: actor=Nadi [P4]; Committed; reason=; event=E407

### Semantic events
- E392 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E393 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E394 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:7->6:ConsumptionSink]
- E395 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E396 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E397 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E398 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E399 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E400 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E401 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E402 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E403 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E404 r12: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:2->1:Gift; P4:2->3:Gift]
- E405 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:6->7:Gift]
- E406 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:7->6:Gift; P2:3->4:Gift]
- E407 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:1->2:Gift]
- E408 r16: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E409 r17: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E410 r18: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False
- E411 r19: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=6; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 22

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P85: actor=Tari [P1]; Committed; reason=; event=E424
- Proposal P86: actor=Rima [P2]; Committed; reason=; event=E425
- Proposal P87: actor=Pala [P3]; Committed; reason=; event=E426
- Proposal P88: actor=Nadi [P4]; Committed; reason=; event=E427

### Semantic events
- E412 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E413 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E414 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E415 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E416 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E417 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E418 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E419 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E420 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E421 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E422 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E423 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E424 r12: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:1->2:Gift]
- E425 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:5->6:Gift]
- E426 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:6->5:Gift; P2:2->3:Gift]
- E427 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:0->1:Gift]
- E428 r16: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E429 r17: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E430 r18: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E431 r19: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=5; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 23

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P89: actor=Tari [P1]; Committed; reason=; event=E442
- Proposal P90: actor=Rima [P2]; Committed; reason=; event=E443
- Proposal P91: actor=Pala [P3]; Committed; reason=; event=E444
- Proposal P92: actor=Nadi [P4]; Committed; reason=; event=E445

### Semantic events
- E432 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E433 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E434 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E435 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E436 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E437 r5: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E438 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E439 r7: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E440 r8: Response; participants=[P2]; detail=Accept; fallback=False
- E441 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E442 r10: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E443 r11: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:4->5:Gift]
- E444 r12: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:5->4:Gift; P2:1->2:Gift]
- E445 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E446 r14: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E447 r15: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=4; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 24

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P93: actor=Tari [P1]; Committed; reason=; event=E460
- Proposal P94: actor=Rima [P2]; Committed; reason=; event=E461
- Proposal P95: actor=Pala [P3]; Committed; reason=; event=E462
- Proposal P96: actor=Nadi [P4]; Committed; reason=; event=E463

### Semantic events
- E448 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E449 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E450 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E451 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E452 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E453 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E454 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E455 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E456 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E457 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E458 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E459 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E460 r12: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:3->2:Gift; P4:3->4:Gift]
- E461 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:1->0:Gift; P3:3->4:Gift]
- E462 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:0->1:Gift]
- E463 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:2->3:Gift]
- E464 r16: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E465 r17: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E466 r18: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E467 r19: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=3; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 25

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P97: actor=Tari [P1]; Committed; reason=; event=E487
- Proposal P98: actor=Rima [P2]; Committed; reason=; event=E488
- Proposal P99: actor=Pala [P3]; Committed; reason=; event=E489
- Proposal P100: actor=Nadi [P4]; Committed; reason=; event=E490

### Semantic events
- E468 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E469 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E470 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E471 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E472 r4: AttitudeDecay; participants=[P1,P2]; detail=0->0; fallback=False
- E473 r5: AttitudeDecay; participants=[P1,P4]; detail=100->98; fallback=False
- E474 r6: AttitudeDecay; participants=[P2,P1]; detail=-19->-18; fallback=False
- E475 r7: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E476 r8: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E477 r9: AttitudeDecay; participants=[P3,P4]; detail=0->0; fallback=False
- E478 r10: AttitudeDecay; participants=[P4,P1]; detail=100->98; fallback=False
- E479 r11: AttitudeDecay; participants=[P4,P3]; detail=6->4; fallback=False
- E480 r12: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E481 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E482 r14: Proposal; participants=[P2]; detail=Farm; fallback=False
- E483 r15: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E484 r16: Response; participants=[P2]; detail=Accept; fallback=False
- E485 r17: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E486 r18: Response; participants=[P1]; detail=Accept; fallback=False
- E487 r19: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:2->1:Gift; P4:2->3:Gift]
- E488 r20: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E489 r21: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:4->5:Gift]
- E490 r22: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:1->2:Gift]
- E491 r23: AttitudeComposition; participants=[P1,P4]; detail=98->100; fallback=False
- E492 r24: AttitudeComposition; participants=[P2,P3]; detail=98->100; fallback=False
- E493 r25: AttitudeComposition; participants=[P4,P1]; detail=98->100; fallback=False

### Stable state
- Tari [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=1; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 26

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P101: actor=Tari [P1]; Committed; reason=; event=E505
- Proposal P102: actor=Rima [P2]; Committed; reason=; event=E506
- Proposal P103: actor=Pala [P3]; Committed; reason=; event=E507
- Proposal P104: actor=Nadi [P4]; Committed; reason=; event=E508

### Semantic events
- E494 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E495 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E496 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E497 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E498 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E499 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E500 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E501 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E502 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E503 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E504 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E505 r11: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:1->2:Gift]
- E506 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:0->1:Gift]
- E507 r13: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E508 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:0->1:Gift]
- E509 r15: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E510 r16: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False
- E511 r17: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=5; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 27

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P105: actor=Tari [P1]; Committed; reason=; event=E522
- Proposal P106: actor=Rima [P2]; Committed; reason=; event=E523
- Proposal P107: actor=Pala [P3]; Committed; reason=; event=E524
- Proposal P108: actor=Nadi [P4]; Committed; reason=; event=E525

### Semantic events
- E512 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E513 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E514 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E515 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E516 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E517 r5: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E518 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E519 r7: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E520 r8: Response; participants=[P2]; detail=Accept; fallback=False
- E521 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E522 r10: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E523 r11: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:4->5:Gift]
- E524 r12: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:5->4:Gift; P2:1->2:Gift]
- E525 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E526 r14: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E527 r15: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=4; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 28

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P109: actor=Tari [P1]; Committed; reason=; event=E540
- Proposal P110: actor=Rima [P2]; Committed; reason=; event=E541
- Proposal P111: actor=Pala [P3]; Committed; reason=; event=E542
- Proposal P112: actor=Nadi [P4]; Committed; reason=; event=E543

### Semantic events
- E528 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E529 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E530 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E531 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E532 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E533 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E534 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E535 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E536 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E537 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E538 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E539 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E540 r12: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:3->2:Gift; P4:3->4:Gift]
- E541 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:1->0:Gift; P3:3->4:Gift]
- E542 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:0->1:Gift]
- E543 r15: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:2->3:Gift]
- E544 r16: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E545 r17: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E546 r18: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E547 r19: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=3; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 29

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P113: actor=Tari [P1]; Committed; reason=; event=E559
- Proposal P114: actor=Rima [P2]; Committed; reason=; event=E560
- Proposal P115: actor=Pala [P3]; Committed; reason=; event=E561
- Proposal P116: actor=Nadi [P4]; Committed; reason=; event=E562

### Semantic events
- E548 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E549 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E550 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E551 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E552 r4: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E553 r5: Response; participants=[P4]; detail=Accept; fallback=False
- E554 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E555 r7: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E556 r8: Response; participants=[P2]; detail=Accept; fallback=False
- E557 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E558 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E559 r11: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:2->1:Gift; P4:2->3:Gift]
- E560 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E561 r13: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:4->5:Gift]
- E562 r14: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:1->2:Gift]
- E563 r15: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E564 r16: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E565 r17: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Tari [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=1; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 30

### Decisions
- Tari [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Tari [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P117: actor=Tari [P1]; Committed; reason=; event=E585
- Proposal P118: actor=Rima [P2]; Committed; reason=; event=E586
- Proposal P119: actor=Pala [P3]; Committed; reason=; event=E587
- Proposal P120: actor=Nadi [P4]; Committed; reason=; event=E588

### Semantic events
- E566 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E567 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E568 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E569 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E570 r4: AttitudeDecay; participants=[P1,P2]; detail=0->0; fallback=False
- E571 r5: AttitudeDecay; participants=[P1,P4]; detail=100->98; fallback=False
- E572 r6: AttitudeDecay; participants=[P2,P1]; detail=-18->-17; fallback=False
- E573 r7: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E574 r8: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E575 r9: AttitudeDecay; participants=[P3,P4]; detail=0->0; fallback=False
- E576 r10: AttitudeDecay; participants=[P4,P1]; detail=100->98; fallback=False
- E577 r11: AttitudeDecay; participants=[P4,P3]; detail=4->2; fallback=False
- E578 r12: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E579 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E580 r14: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E581 r15: Response; participants=[P3]; detail=Accept; fallback=False
- E582 r16: Proposal; participants=[P3]; detail=Farm; fallback=False
- E583 r17: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E584 r18: Response; participants=[P1]; detail=Accept; fallback=False
- E585 r19: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:1->2:Gift]
- E586 r20: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:0->1:Gift]
- E587 r21: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E588 r22: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:0->1:Gift]
- E589 r23: AttitudeComposition; participants=[P1,P4]; detail=98->100; fallback=False
- E590 r24: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False
- E591 r25: AttitudeComposition; participants=[P4,P1]; detail=98->100; fallback=False

### Stable state
- Tari [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Rima [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=5; NeedsGrain=False; dwelling=D1
- Nadi [P4]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Stop

- Horizon:30
