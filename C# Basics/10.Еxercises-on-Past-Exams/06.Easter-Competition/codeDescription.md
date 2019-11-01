6. Easter competition:
As Easter approaches, a bakery is organizing a contest to make the best cashew. Write a program to find the highest-rated confectioner. 
At the beginning of the competition, the number of Kozunaks that will be tasted by the visitors of the bakery is introduced, and for each Kozunak a different number of visitors will give a rating from 1 to 10.
Input:
Initially, the console reads the number of Kozunaks - an integer in the range [1… 100]
Then for each weasel read:
• The name of the baker who made the insect - text
• By the time the Stop command is received, it is read
• assessment of one-person weed - an integer in the range [1 ... 10]
Output:
After receiving the Stop command, one line is printed:
• "{baker name} has {total points received} points."
If after the Stop command, the baker has the most points to date, print an additional line:
• "{Baker's Name} is the new number 1!"
After tasting all the Kozunaks, print one line:
• "{baker name with highest points} won competition with {baker points} points!"
Example input and output:
Input:
3
Chef Manchev
10
10
10
10
Stop
Natalie
8
2
9
Stop
George
9
2
4
2
Stop
Output:
Chef Manchev has 40 points.
Chef Manchev is the new number 1!
Natalie has 19 points.
George has 17 points.
Chef Manchev won competition with 40 points!
Input:
2
Chef Angelov
9
9
9
Stop
Chef Rowe
10
10
10
10
Stop
Output:
Chef Angelov has 27 points.
Chef Angelov is the new number 1!
Chef Rowe has 40 points.
Chef Rowe is the new number 1!
Chef Rowe won competition with 40 points!
