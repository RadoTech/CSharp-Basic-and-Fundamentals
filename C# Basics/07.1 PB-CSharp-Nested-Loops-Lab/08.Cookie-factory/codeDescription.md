Judge 90/100
8. Cookie Factory
The cookie factory receives orders every day. Write a program that helps pastry chefs make cookies faster by just bringing the necessary products into your computer.
The main components are flour, eggs and sugar and they should always be present in the mixture. Different types of cookies are added for different types of cookies, their number is not limited. As an input, the program will first take an integer - the number of batches to be made today. The following lines will introduce the products for each mixture.
When you enter the command "Bake!", The corresponding mixture will be put in the oven.
 If the baking mixture does not contain at least one of the required ingredients: flour, eggs or sugar, it should be written:
"The batter should contain flour, eggs and sugar!"
, and if it contains all the components
"Baking batch number {batch number we bake} ...".
Example input and output:
Input:
2
flour
eggs
sugar
chocolate
Bake!
flour
eggs
sugar
caramel
peanuts
Bake!
Output:
Baking batch number 1...
Baking batch number 2...
Input:
3
flour
eggs
jam
Bake!
sugar
Bake!
flour
eggs
milk
almonds
sugar
Bake!
flour
eggs
sugar
Bake!
Output:
The batter should contain flour, eggs and sugar!
Baking batch number 1...
Baking batch number 2...
Baking batch number 3...
