Programming Basics Exam - November 2 and 3, 2019:
Task 6. Substitute:
Pepi's favorite team is in the finals, but goes on to lose the match. The coach of the team does not know what changes he has to make to turn the result. Write a program to find out which are the first 6 shifts that can be made. We know that each digit of the two numbers is in a given interval. In order for one shift to be possible, the first number of the numbers must be odd and the second odd.
Input:
The console reads:
• K - beginning of the interval for the first number of the first number - digit in the interval [0..8]
• L - beginning of the interval for the second number of the first number - digit in the interval [9..0]
• M - beginning of the interval for the first number of the second number - digit in the interval [0..8]
• N - beginning of the interval for the second number of the second number - digit in the interval [9..0]
Exit
To print the first 6 possible changes on the console as follows:
• If a change is possible and the numbers do not match, print:
"{K} {L} - {M} {N}"
• If a change is possible and the numbers match, print:
"Cannot change the same player."
Input:
7
6
8
5
Output:
Cannot change the same player.
89 - 87
89 - 85
87 - 89
Cannot change the same player.
87 - 85
Clarifications:
