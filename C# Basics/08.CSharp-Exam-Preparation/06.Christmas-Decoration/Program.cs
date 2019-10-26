using System;

namespace ChristmasDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:
            int budget = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            //Logic:
            int currentItemASCISum = 0;

            while (command != "Stop")
            {
                for (int i = 0; i < command.Length; i++)
                {
                    int currentItemASCI = command[i];
                    currentItemASCISum += currentItemASCI;
                }
                if (currentItemASCISum <= budget)
                {
                    Console.WriteLine("Item successfully purchased!");
                    budget -= currentItemASCISum;
                }
                else if (currentItemASCISum > budget)
                {
                    Console.WriteLine("Not enough money!");
                    return;
                }
                currentItemASCISum = 0;
                command = Console.ReadLine();
            }
            Console.WriteLine($"Money left: {budget}");
        }
    }
}
