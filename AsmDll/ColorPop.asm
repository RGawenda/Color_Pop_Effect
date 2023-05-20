 ; Temat: Color pop
 ; Roman Gawenda semestr 5 2022/2023
 ; Biblioteka ASM

.data
r DD 0.3f
g DD 0.59f
b DD 0.11f

.code
MakeGrayA proc

VMOVUPS xmm0, xmmword ptr [RCX]			;Przeniesienie 8 bajtów do xmm0
VPMOVZXBD ymm0, xmm0					;Konwersja bajtów na inty miejsca pomiêdzy s¹ wype³niane zerami
VCVTDQ2PS ymm0, ymm0					;Konwersja intów na floaty

VMOVUPS xmm1, xmmword ptr [RDX]
VPMOVZXBD ymm1, xmm1
VCVTDQ2PS ymm1, ymm1

VMOVUPS xmm2, xmmword ptr [R8]
VPMOVZXBD ymm2, xmm2
VCVTDQ2PS ymm2, ymm2


VBROADCASTSS ymm3, r					;wype³nienie ymm3, ymm4 oraz ymm5 floatami które s¹ pod r, g oraz b 
VBROADCASTSS ymm4, g
VBROADCASTSS ymm5, b

VMULPS ymm0, ymm0, ymm3					;wymno¿enie ymm0 razy ymm3, ymm1 razy ymm4 oraz ymm2 razy ymm5
VMULPS ymm1, ymm1, ymm4
VMULPS ymm2, ymm2, ymm5

VADDPS ymm0, ymm0, ymm1					;dodanie ymm1 oraz ymm2 do ymm0
VADDPS ymm0, ymm0, ymm2

VCVTTPS2DQ ymm0, ymm0					;Konwersja ymm0 z floatów do intów

pextrb byte ptr [RCX+0], xmm0, 0		;skopiowanie bajta od wskazanej pozycji pod wskaŸnik zawarty w RCX
pextrb byte ptr [RCX+1], xmm0, 4
pextrb byte ptr [RCX+2], xmm0, 8
pextrb byte ptr [RCX+3], xmm0, 12

VPERMQ ymm0, ymm0, 11111110b			;zamienia miesjcami dolne i górne 128 bitów ymm

pextrb byte ptr [RCX+4], xmm0, 0		;skopiowanie bajta od wskazanej pozycji pod wskaŸnik zawarty w RCX
pextrb byte ptr [RCX+5], xmm0, 4
pextrb byte ptr [RCX+6], xmm0, 8
pextrb byte ptr [RCX+7], xmm0, 12

ret
MakeGrayA endp
end
