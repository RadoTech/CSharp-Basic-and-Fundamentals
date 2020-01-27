using System;

namespace spiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalSpice = 0;
            int days = 0;
            if (startingYield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(totalSpice);
            }
            else if (startingYield >= 100)
            {
                for (int spice = startingYield; spice >= 100; spice -= 10)
                {
                    totalSpice += startingYield;
                    if (totalSpice >= 26)
                    {
                        totalSpice -= 26;
                    }
                    else
                    {
                        totalSpice = 0;
                    }
                    startingYield -= 10;
                    days++;
                }
                totalSpice -= 26;
                Console.WriteLine(days);
                Console.WriteLine(totalSpice);
            }
        }
    }
}
