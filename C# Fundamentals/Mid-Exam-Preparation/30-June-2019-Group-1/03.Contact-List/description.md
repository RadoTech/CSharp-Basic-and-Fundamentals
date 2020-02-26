03. Contact List
Create a program that helps you keep track of the contacts that you have. You will receive the list of contacts you already have on a single line, separated by a single space in the following format:
"{contact1} {contact2} {contact3}… {contactn}"
Then you will receive commands that you need to execute over your list. There are four possible commands:
•	"Add {contact} {index}":
o	If {contact} isn’t already contained – add it in the end of the collection.
o	If {contact} is already contained – add it on the given index, if the index exists.
•	"Remove {index}"
o	Remove the contact on the given index, if the index exists.
•	"Export {startIndex} {count}":
o	Print the next {count} contacts starting from the given {startIndex} (including), separated by a single space. If the count requested is more than the contacts- just print them to the end. 
"{contact} {contact} {contact}"
•	"Print Normal/Reversed"
o	Print the contact list in normal (in the order they have been added) or reversed order and then stop the program:
"Contacts: {contact1} {contact2}… {contactn}"
Input
•	On the 1st line, you will receive the starting list with the names of the contacts separated by a single space.
•	On the next lines, you will receive commands in the format described above.
Output
•	Print the needed output upon the "Export" command.
•	Print the list after the manipulations upon the "Print" command in the format described above.
 
Examples
Input
Alisson Bellamy Candace Tristan
Remove 3
Add Bellamy 2
Print Normal

Output
Contacts: Alisson Bellamy Bellamy Candace
Comments
First, we receive the “Remove 3” command, so we remove the contact at index 3 (“Tristan”).
Then, we receive the command “Add Bellamy 2” but we already have “Bellamy” in our collection, so we add it on index 2.
Lastly, we have to print the collection in normal order, so our output is: “Contacts: Alisson Bellamy Bellamy Candace”

Input
Zayn Katy Ariana Avril Nick Mikolas
Remove 3
Add Jacob 0
Export 0 3
Export 3 8
Print Reversed
Output
Zayn Katy Ariana
Nick Mikolas Jacob
Contacts: Jacob Mikolas Nick Ariana Katy Zayn
