Task 6. High jump
Bulgarian track and field athlete Tihomir Ivanov begins training for the upcoming European Indoor Athletics Championships in Glasgow, Scotland.
Your job is to write software to keep track of your progress and whether it has achieved the desired results. At the beginning, the program gets the desired height of the bar from Tihomir, he begins his training by setting the bar at a height of 30 cm below the target. He is entitled to 3 jumps for each height, and in order to be successful one jumper must be above the height of the bar. Upon successful jump (above the bar), its height rises by 5 centimeters. With three unsuccessful jumps at the same height, the workout ends in failure. Upon reaching the desired height and successfully jumping over, the training ends successfully.
Input:
The input is a series of integers in the range [100… 300]:
• The first line reads the desired height by Tihomir Ivanov in centimeters
• The height of Ivanov's jump is read on each subsequent line until the program ends
Output:
One row must be printed on the console:
• If Tihomir fails to reach the desired height:
• "Tihomir failed at {height at the time of failure} cm after {number of jumps since start of training} jumps."
• If Tihomir manages to overcome the height:
• "Tihomir succeeded, he jumped over {jumps last jump} cm after {number of jumps for the whole workout}."
Example input and output:
Input:
231
205
212
213
228
229
230
235
Output:
Tihomir succeeded, he jumped over 231cm after 7 jumps.
