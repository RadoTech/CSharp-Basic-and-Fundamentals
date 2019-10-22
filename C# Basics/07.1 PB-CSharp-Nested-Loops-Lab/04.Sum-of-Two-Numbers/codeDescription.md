4. Sum of two numbers:
Write a program that checks all possible combinations of a pair of numbers in the interval of two given numbers. The output shows which sequence is the combination whose sum of numbers is equal to a magic number. If there is no eligible combination, a message is printed that it is not found.
Sign in
The input is read from the console and consists of three lines:
• First row - beginning of the interval - integer in the interval [1 ... 999]
• Second row - end of interval - integer in interval [greater than first number ... 1000]
• Third row - the magic number - an integer in the interval [1 ... 10000]
Exit
One row must be printed on the console according to the result:
• If a combination is found whose sum is equal to the magic number
o "Combination N: {sequence number} ({first number} + {second number} = {magic number})"
• If a matching condition is not found
o "{number of all combinations} combinations - none equals {magic number}"
Example input and output:
Input:
Вход
1
10
5
Output:
Combination N:4 (1 + 4 = 5)
Input:
88
888
1000
Output:
Combination N:20025 (112 + 888 = 1000)
Input:
88
888
2000
Output:
641601 combinations - neither equals 2000
