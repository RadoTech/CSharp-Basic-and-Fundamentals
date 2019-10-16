using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washmachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toyCount = 0;
            int bDayMoney = 0;
            int stolenMoney = 0;
            int bDayMoneySaved = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toyCount++;
                }
                else if (i % 2 == 0)
                {
                    bDayMoney += 10;
                    bDayMoneySaved += bDayMoney;
                    stolenMoney++;
                }
            }
            int toyMoney = toyCount * toyPrice;
            int savedMoney = bDayMoneySaved + toyMoney - stolenMoney;

            if (savedMoney >= washmachine)
            {
                double restMoney = savedMoney - washmachine;
                Console.WriteLine($"Yes! {restMoney:f2}");
            }
            else if (savedMoney < washmachine)
            {
                double neededMoney = washmachine - savedMoney;
                Console.WriteLine($"No! {neededMoney:f2}");
            }
        }
    }
}
