3. Coding
Write a program that reads an integer from the console. The number of rows as many as the number should be printed on the console. The first line corresponds to the units, the second row the tens, the third row the hundreds of the number, etc., until they finish the digits of the number. Each line must be printed with a symbol that meets the following conditions:
• The character to be printed in a row is from the ASCII table. Its decimal ASCII code is to be added to the digit of the number entered corresponding to a line 33
• The symbol is printed as many times as the digit corresponding to that line
• if digit 0 corresponds to one line, "ZERO" is printed once
Example input and output:
input:
2049
output:
*********
%%%%
ZERO
##
input:
9347439
output:
*********
$$$
%%%%
(((((((
%%%%
$$$
*********
input:
123456789
output:
*********
))))))))
(((((((
''''''
&&&&&
%%%%
$$$
##
"
