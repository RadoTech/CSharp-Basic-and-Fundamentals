Task 6. Basketball tournaments
Desi and her basketball team participate in tournaments every month, each tournament consisting of a number of matches. Each match has a final result, based on which the winner is determined. The team that has scored the most points is considered the winner. Help Desi compile statistics for the tournaments he and his team participate in. As an entry you will receive tournament names until you receive the "End of tournaments" command. For each tournament you will receive an integer indicating the number of matches played for the tournament. For each match you will receive: on the first line the points scored by Desi's team and on the second line - the points scored by the opponent's team. After receiving the points for each match, print:
 If Desi's team has won (ie, the points scored by its team are more than the points of the opponent's team): "Game {what is the match number they have played for the current tournament} of tournament {name of tournament}: win with {the difference between Dessie's team points and the opponent's team} points. "
 If Dessy's team has lost (i.e., the points scored by its team are less than the points scored by the opponent's team): "Game {what is the match number they have played for the current tournament} of tournament {lost name {the difference between the points of the opposing team and the team of Desi} points. "
There will be no cases of equality.
Input:
The console reads a series of tournaments until receiving the "End of tournaments" command:
• Tournament name - text
• For each tournament, n matches - integer in the interval [1… 15]
• There are two lines for each match:
• Points scored by Desi's team - an integer in the range of [0… 150]
• Points scored by the opposing team - an integer in the range of [0… 150]
Output:
The following lines should be printed on the console:
• After each match, print whether the team of Desi has won or lost, and with what difference.
• When receiving the "End of tournaments" command, print two lines:
• {percentage of matches won in all tournaments}% matches win
• {percentage of matches lost in all tournaments}% matches lost
All percentages must be formatted to the second digit after the decimal point.
Example input and output:
Input:
Ballers
3
87
63
56
65
75
64
Sharks
4
64
76
65
86
68
99
45
78
End of tournaments 
Output:
Game 1 of tournament Ballers: win with 24 points.
Game 2 of tournament Ballers: lost with 9 points.
Game 3 of tournament Ballers: win with 11 points.
Game 1 of tournament Sharks: lost with 12 points.
Game 2 of tournament Sharks: lost with 21 points.
Game 3 of tournament Sharks: lost with 31 points.
Game 4 of tournament Sharks: lost with 33 points.
28.57% matches win
71.43% matches lost
