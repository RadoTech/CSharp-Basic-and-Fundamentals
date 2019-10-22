using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            double savedMoney = 0;

            while (destination != "End")
            {
                double budgetNeeded = double.Parse(Console.ReadLine());

                for (double saving = 0; savedMoney < budgetNeeded; saving = double.Parse(Console.ReadLine()))
                {
                    savedMoney += saving;
                    if (savedMoney >= budgetNeeded)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        savedMoney = 0;
                        break;
                    }
                }
                
                destination = Console.ReadLine();

            }
        }
    }
}
