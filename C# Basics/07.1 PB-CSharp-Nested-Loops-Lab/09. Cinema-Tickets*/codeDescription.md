Sample exam exercise:
9. * Movie tickets
Your job is to write a program that calculates the percentage of tickets for each type of ticket sold: student (student), standard (standard) and kid (kid), for all screenings. You also need to calculate how many percent of the room is filled for each projection.
Sign in
The input is a series of integers and text:
• The first line until you receive the command "Finish" - movie name - text
• In the second row - the seats available in the salon for each projection - an integer [1… 100]
• For each movie, one line is read until the available seats are exhausted or until the "End" command is received:
o Ticket type purchased - text ("student", "standard", "kid")
Exit
The following lines must be printed on the console:
• After each movie, how many percent of the cinema room is full
"{movie name} - {occupancy rate}% full."
• When receiving the Finish command, print four lines:
o "Total tickets: {total number of tickets purchased for all movies}"
o "{Student ID Percentage}% student tickets."
o "{Standard Ticket Rate}% standard tickets."
o "{Kids Ticket Percentage}% kids tickets."
Example input and output:
Login /Exit /Explanations:
The Matrix
20
student
standard
kid
kid
student
student
standard
student
End
The Green Mile
17
student
standard
standard
student
standard
student
End
Amadeus
3
standard
standard
standard
Finish The Matrix - 40.00% full.
The Green Mile - 35.29% full.
Amadeus - 100.00% full.
Total tickets: 17
41.18% student tickets.
47.06% standard tickets.
11.76% kids tickets. The first movie - The Matrix, seats in the hall are 20
We buy 2 standard, 4 student, 2 children's tickets and receive the End command.
A total of 8 tickets from 20 seats -> 41.18% of the hall is occupied
Second movie - The Green Mile, seats in the hall are 17
We buy 3 standard, 3 student tickets and receive the End command.
A total of 6 tickets from 17 seats -> 47.06% of the hall is occupied
Third movie - Amadeus, seats in the hall are 3
3 standard tickets are purchased and seats are expired.
A total of 3 tickets from 3 seats -> 100% of the hall is occupied.
We get the Finish command
The total number of tickets purchased for all films is 17.
All movies purchased in total:
7 student tickets. 7 tickets out of 17 total is 41.18%
8 standard tickets. 8 tickets out of 17 total is 47.06%
2 children's tickets. 2 tickets out of 17 total is 11.76%
