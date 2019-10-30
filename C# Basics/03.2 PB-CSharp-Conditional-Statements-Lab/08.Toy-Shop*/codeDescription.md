10. Toy Store:
Petya has a toy store. She gets a big order to fulfill. With the money he will win he wants to go on a field trip. Write a program that calculates the profit from the order.
Toy prices:
• Puzzle - 2.60 lv.
• Talking doll - 3 BGN
• Teddy Bear - BGN 4.10
• Minion - 8.20 BGN
• Truck - 2 BGN
If the toys ordered are 50 or more, the store discounts 25% of the total price. From the money earned, Petya has to give 10% of the rent to the store. Calculate if the money will go to her for a trip.
Sign in
The console reads 6 lines:
• Price of the excursion - real number in the interval [1.00… 10000.00]
• Number of puzzles - integer in the range [0… 1000]
• Number of talking dolls - integer in the range [0… 1000]
• Number of teddy bears - integer in the range [0… 1000]
• Number of minions - integer in the range [0… 1000]
• Number of lorries - integer in the range [0… 1000]
Exit
The console prints:
• If enough money is printed:
• "Yes! {leftover money} lv left."
• If the money is NOT sufficient, the following is printed:
• "Not enough money! {needed money} lv needed."
The result should be formatted to the second character after the decimal point.
Example input and output:
Input:
40.8
20
25
30
50
10
Output:
Yes! 418.20 lv left.
Input:
320
8
2
5
5
1
Output:
Not enough money! 238.73 lv needed.
