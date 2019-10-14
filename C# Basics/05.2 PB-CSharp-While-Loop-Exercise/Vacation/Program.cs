﻿using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //logic
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            //logic

            int daysCounter = 0;
            int spendingCounter = 0;

            while ((ownedMoney < neededMoney) && (spendingCounter < 5))
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if (command == "save")

                {
                    ownedMoney += money;
                    spendingCounter = 0;
                }
                else if (command == "spend")
                {
                    ownedMoney -= money;
                    spendingCounter += 1;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                }
            }

            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (ownedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }





        }
    }
}
