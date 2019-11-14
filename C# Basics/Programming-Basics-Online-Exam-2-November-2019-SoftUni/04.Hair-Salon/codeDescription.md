4. Hairdressing salon:
Desi has a hair salon in Sofia. It aims to make a profit every day. Write a program that calculates whether she has reached her goal of the day knowing the following:
Desi will accept clients until the business day is over. However, if it achieves the desired revenue, it will close the salon. When a client logs in, they will be able to choose one of the following services:
• Haircut:
o Men (mens) - 15lv.
o Ladies - 20lv.
o Kids - 10lv.
• Painting:
o Support (touch up) - 20lv.
o Full color - 30lv.
Input:
The console initially reads 1 line:
day target - integer in the range [1… 5000]
Then read a series of lines until receiving the command "closed" or until Desi reaches the goal of the day - the service the client wants - text with options "haircut", "color" and "other". The "haircut" command is expected to enter the type of haircut - "mens", "ladies" or "kids", and the "color" command will expect the type of coloring - "touch up" or "full color"
Output:
2 lines are printed on the console:
•	At the first row:
o If Desi was able to reach her goal of the day:
"You have reached your target for the day!"
o If Desi failed to reach her goal of the day:
"Target not reached! You need {how much money does not reach her goal} lv. More."
• In the second line:
"Earned money: {the money she earned for the day} lv."
Example input and output:
Input:
300
haircut
ladies
haircut
kids
color
touch up
closed
Output:
Target not reached! You need 250lv. more.
Earned money: 50lv.
