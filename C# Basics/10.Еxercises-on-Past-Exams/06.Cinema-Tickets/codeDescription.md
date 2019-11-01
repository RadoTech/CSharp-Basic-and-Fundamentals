Task 6. Cinema tickets
Your job is to write a program that calculates the percentage of tickets for each type of ticket sold: student (student), standard (standard) and kid (kid), for all screenings. You also need to calculate how many percent of the room is filled for each projection.
Sign in
The input is a series of integers and text:
• The first line until you receive the command "Finish" - movie name - text
• Second row - the seats available in the drawing room for each projection - integer [1… 100]
• For each movie, one line is read until the seats are exhausted or until the "End" command is received:
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
Input:
Taxi
10
standard
kid
student
student
standard
standard
End
Scary Movie
6
student
student
student
student
student
student
Finish
Output:
Taxi - 60.00% full.
Scary Movie - 100.00% full.
Total tickets: 12
66.67% student tickets.
25.00% standard tickets.
8.33% kids tickets.
