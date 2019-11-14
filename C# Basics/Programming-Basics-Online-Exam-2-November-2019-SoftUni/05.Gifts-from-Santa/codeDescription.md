5. Santa gifts
Santa begins to go from town to town to bring presents to all obedient children. He asks you to write a program that prints on the console all the address numbers from M to N, which are divided into 2 and 3 at the same time, since Santa knows that only obedient children live there. Another number will be read from the console at address S. If any of the divisible addresses 2 and 3 equals the address S, this address should not be printed and the program must end. Otherwise, all address numbers up to N that are eligible are printed.
Input:
The console reads exactly 3 numbers, each in a separate line:
• N - integer - 0 <= N <M
• M - integer - N <M <= 10000
• S - integer - N <= S <= M
Output:
The console prints in a single row, all address numbers eligible for space separated.
Example Input:
1
30
15
Example Output:
30 24 18 12 6
