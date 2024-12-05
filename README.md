# Projecte-Prova-2-Hugo

## Ex4

```4. A partir d'una màquina senzilla que pot executar 4 operacions (2 punts):
CMP -> 00 MOV-> 01 ADD -> 10  BEQ -> 11

Tradueix a llenguatge de baix nivell les següents instruccions, indicant la instrucció sencera (de 16 bits) en format binari que ha d’executar la màquina:
CMP 2F, 35
MOV AB, 74
ADD 12, 43
MOV A8, 66
```


base 16-> 0 1 2 3 4 5 6 7 8 9 A(10) B(11) C(12) D(13) E(14) F(15)

1.-
CMP 2F, 35

cmp -> 00

2F -> 2 / 15 -> 0010 / 1111 

35 -> 3 / 5 -> 0011 / 0101

a) -> 00 00101111  00110101

2.-
MOV AB, 74

mov -> 01

AB -> 10 / 11 -> 1010 / 1011 

74 -> 7 / 4 -> 0111 / 0100

b) -> 01 10101011 01110100

3.-
ADD 12, 43

ADD -> 10

12 -> 1 / 2 -> 0001 / 0010

43 -> 4 / 3 -> 0100 / 0011

c) -> 10 00010010 01000011

4.-
MOV A8, 66

mov -> 01

A8 -> 10 / 8 -> 1010 / 1000

66 -> 6 / 6 -> 0110 / 0110

d) -> 01 10101000 01100110

