7. Building:
Write a program that displays the room numbers in one building (in descending order) on the console, subject to the following conditions:
• There are only offices on each even floor
• There are only apartments on each odd floor
• Each apartment is designated as follows: A {floor number} {apartment number}, apartment numbers start at 0.
• Each office is designated as follows: О {floor number} {office number}, office numbers also start at 0.
• There are always apartments on the top floor and they are larger than the others, so their number says 'L' instead of 'A'. If there is only one floor, then there are only large apartments!
Two integers are read from the console - the number of floors and the number of rooms per floor.
Example input and output:
Input:
Вход
6
4
Output:
L60 L61 L62 L63
A50 A51 A52 A53
O40 O41 O42 O43
A30 A31 A32 A33
O20 O21 O22 O23
A10 A11 A12 A13
Input:
9
5
Output:
9
5	L90 L91 L92 L93 L94
O80 O81 O82 O83 O84
A70 A71 A72 A73 A74
O60 O61 O62 O63 O64
A50 A51 A52 A53 A54
O40 O41 O42 O43 O44
A30 A31 A32 A33 A34
O20 O21 O22 O23 O24
A10 A11 A12 A13 A14
