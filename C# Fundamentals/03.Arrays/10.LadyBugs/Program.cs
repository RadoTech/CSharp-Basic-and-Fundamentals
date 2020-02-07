using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine()); //input
            int[] indexes = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int[] initialField = new int[fieldSize]; //creating field for lady bugs
            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] < initialField.Length
                    && indexes[i] >= 0)
                {
                    initialField[indexes[i]] = 1; //defining where are lady bugs initially
                }
            }

            string input = Console.ReadLine();
            string[] command = new string[3];

            while (input != "end")
            {
                command = input.Split().ToArray();
                int ladyBug = int.Parse(command[0]); //command separation on 3 parts
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (ladyBug < initialField.Length //check position is in the field
                    && ladyBug >= 0
                    && initialField[ladyBug] == 1 //and if there is a lady bug
                    && flyLength != 0) //and if it's moving at all
                {
                    if (direction == "right") //if lady bug is moving to the right
                    {
                        if (ladyBug + flyLength < initialField.Length //if it's moving in the field
                            && ladyBug + flyLength >= 0                
                            && initialField[ladyBug + flyLength] == 0) //and if the place to go is free;
                        {
                            initialField[ladyBug + flyLength] = 1; //if yes, this place is being taken
                        }
                        else if (ladyBug + flyLength < initialField.Length
                                 && ladyBug + flyLength >= 0
                                 && initialField[ladyBug + flyLength] == 1) //if the place to go is NOT FREE
                        {
                            while (ladyBug + flyLength < initialField.Length
                                   && ladyBug + flyLength >= 0
                                   && initialField[ladyBug + flyLength] == 1) //moving forward with same step count until finds a free place.
                            {
                                flyLength += flyLength; //that's why we are increasing the step with the same amount;
                                if (ladyBug + flyLength < initialField.Length
                                    && ladyBug + flyLength >= 0 // check for negative number which will cause the lady bug to step out left of the field;
                                    && initialField[ladyBug + flyLength] == 0)
                                {
                                    initialField[ladyBug + flyLength] = 1; //if free place found, will be taken
                                    break; //and step out of the loop
                                }
                            }
                        }
                    }
                    else if (direction == "left") //same logic for moving left
                    {
                        if (ladyBug - flyLength >= 0 // the moving here is with minus
                            && ladyBug - flyLength < initialField.Length
                            && initialField[ladyBug - flyLength] == 0)
                        {
                            initialField[ladyBug - flyLength] = 1;
                        }
                        else if (ladyBug - flyLength >= 0
                                 && ladyBug - flyLength < initialField.Length
                                 && initialField[ladyBug - flyLength] == 1)
                        {
                            while (ladyBug - flyLength >= 0 // until (while loop) finds a free place
                                   && ladyBug - flyLength < initialField.Length
                                   && initialField[ladyBug - flyLength] == 1)
                            {
                                flyLength += flyLength; // keeping plus
                                if (ladyBug - flyLength >= 0
                                    && ladyBug - flyLength < initialField.Length
                                    && initialField[ladyBug - flyLength] == 0)
                                {
                                    initialField[ladyBug - flyLength] = 1;
                                    break;
                                }
                            }
                        }
                    }

                    initialField[ladyBug] = 0; //if the code enters the very first if statement = ladybug has taken of its initial position.
                }

                input = Console.ReadLine(); // reading again the very first while loop.
            }

            Console.WriteLine(String.Join(" ", initialField)); //Output after all loops are over.
        }
    }
}