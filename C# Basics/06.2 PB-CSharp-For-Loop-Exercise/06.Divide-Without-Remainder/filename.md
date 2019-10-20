6. Divide Without Remainder
N-number integers are given in the interval [1… 1000]. Of these, some percentage p1 is divisible by the remainder of 2, another percentage p2 is divided by the remainder by 3, another percentage p3 is divided by the remainder by 4. Write a program that calculates and prints the percentages p1, p2 and p3.
Example: we have n = 10 numbers: 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. We get the following distribution and visualization:
Divide without remainder by: Numbers in the range Number of numbers Percent
2 680, 2, 600, 200, 800, 46, 128 7 p1 = 7.0 / 10 * 100 = 70.00%
3 600 1 p2 = 1/10 * 100 = 10.00%
4 680, 600, 200, 800, 128 5 p3 = 5/10 * 100 = 50.00%
Input:
The first line of the input is an integer n (1 ≤ n ≤ 1000) - number of numbers. The next n lines have one integer in the interval [1… 1000] - the numbers to be checked by how many can be divided.
Output:
Print on the console 3 rows, each containing a percentage between 0% and 100%, with an accuracy of two digits after the decimal point, for example 25.00%, 66.67%, 57.14%.
• First line - the percentage of numbers that divide by 2
• Second row - the percentage of the numbers that divide by 3
• Third row - the percentage of numbers that divide by 4
Example input and output:
Input:
10
680
2
600
200
800
799
199
46
128
65
Output:
70.00%
10.00%
50.00%
Input:
3
3
6
9
Output:
33.33%
100.00%
0.00%
