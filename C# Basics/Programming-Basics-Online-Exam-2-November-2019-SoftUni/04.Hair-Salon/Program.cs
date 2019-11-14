using System;

namespace HairSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            double goal = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            //Logic:

            double moneyEarned = 0;
            string subCommand = String.Empty;

            while (command != "closed")
            {
                subCommand = Console.ReadLine();

                if (command == "haircut")
                {
                    if (subCommand == "mens")
                    {
                        moneyEarned += 15;
                    }
                    else if (subCommand == "ladies")
                    {
                        moneyEarned += 20;
                    }
                    else if (subCommand == "kids")
                    {
                        moneyEarned += 10;
                    }
                }
                else if (command == "color")
                {
                    if (subCommand == "touch up")
                    {
                        moneyEarned += 20;
                    }
                    else if (subCommand == "full color")
                    {
                        moneyEarned += 30;
                    }
                }
                else if (command == "other")
                {
                    continue;
                }
                if (moneyEarned >= goal)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (moneyEarned >= goal)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {moneyEarned}lv.");
            }
            else if (moneyEarned < goal)
            {
                Console.WriteLine($"Target not reached! You need {goal - moneyEarned}lv. more.");
                Console.WriteLine($"Earned money: {moneyEarned}lv.");
            }
            
        }
    }
}
