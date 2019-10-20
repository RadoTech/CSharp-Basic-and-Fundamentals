5. Histogram:
N integers are given in the interval [1… 1000]. Of these, some percent of p1 are below 200, another percent of p2 is 200 to 399, another percent of p3 is 400 to 599, another percent of p4 is 600 to 799, and the remaining p5 percent is 800 up. Write a program that calculates and prints the percentages p1, p2, p3, p4, and p5.
Example: we have n = 20 numbers: 53, 7, 56, 180, 450, 920, 12, 7, 150, 250, 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. We get the following distribution and visualization:
Диапазон	Числа в диапазона	Брой числа	Процент
< 200	53, 7, 56, 180, 12, 7, 150, 2, 199, 46, 128, 65	12	p1 = 12 / 20 * 100 = 60.00%
200 … 399	250, 200	2	p2 = 2 / 20 * 100 = 10.00%
400 … 599	450	1	p3 = 1 / 20 * 100 = 5.00%
600 … 799	680, 600, 799	3	p4 = 3 / 20 * 100 = 15.00%
≥ 800	920, 800	2	p5 = 2 / 20 * 100 = 10.00%
Input:
The first line of the input is an integer n (1 ≤ n ≤ 1000) - number of numbers. The next n lines have one integer in the range [1… 1000] - the numbers on which to calculate the histogram.
Output:
Print a histogram on the console - 5 rows, each containing a number between 0% and 100%, with two digits after the decimal point, for example 25.00%, 66.67%, 57.14%.
Example input and output:
Input:
14
53
7
56
180
450
920
12
7
150
250
680
2
600
200
Output:
57.14%
14.29%
7.14%
14.29%
7.14%

