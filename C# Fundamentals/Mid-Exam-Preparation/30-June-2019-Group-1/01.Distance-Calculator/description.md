01. Distance Calculator
Create a program that calculates what percentage you’ve travelled. First, you will receive how many steps you’ve made. Then, you will receive how long 1 step is in centimeters. Last, you will receive the distance you need to travel in meters.
Then you have to calculate what distance you have travelled with the steps given. Have in mind that every fifth step is 30% shorter than usual. You have to calculate what percentage of the distance you’ve travelled.
In the end, print the percentage of the distance travelled, formatted to the 2nd decimal place, in the following format:
"You travelled {percentage}% of the distance!"
Input
•	On the 1st line you will receive the steps made – an integer number in the range [0…100000]
•	On the 2nd line you will receive the length of 1 step – a real number in the range [0.0…50.0]
•	On the 3rd line you will receive the distance you need to travel – an integer number in the range [0…100000]
Output
•	In the end print the percentage of the distance travelled formatted to the 2nd decimal place in the format described above.
Constraints
•	The input will always be in the right format.
•	Percentage can be over 100%.
 
Examples
Input
100
2
1
Output
You travelled 188.00% of the distance!
Comments
The length of a step is 2 centimeters. Every fifth step will be 1.4 centimeters long. 20 shorter steps are made. The distance that has to be travelled is 1 meter. The distance travelled is 1.88 meters which is 188% of the distance that had to be travelled.
Input
5000
7.5
500
Output
You travelled 70.50% of the distance!
