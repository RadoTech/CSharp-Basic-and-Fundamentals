using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int cakeW = int.Parse(Console.ReadLine());
            int cakeL = int.Parse(Console.ReadLine());

            //logic

            int cakeV = cakeW * cakeL;

            string command;
            int numberTaken = 0;

            while ((command = Console.ReadLine()) != "STOP")
            {
                int number = int.Parse(command);
                numberTaken += number;
                if (numberTaken > cakeV)
                {
                    int numberNeeded = numberTaken - cakeV;
                    Console.WriteLine($"No more cake left! You need {numberNeeded} pieces more.");
                    return;
                }
            }
            if (command == "STOP")
            {
                int numberLeft = cakeV - numberTaken;
                Console.WriteLine($"{numberLeft} pieces are left.");
            }

        }
    }
}
