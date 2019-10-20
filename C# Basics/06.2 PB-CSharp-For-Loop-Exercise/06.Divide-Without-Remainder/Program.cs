using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            for (int i = 1; i <= numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                {
                    p1++;
                }
                if (currentNumber % 3 == 0)
                {
                    p2++;
                }
                if (currentNumber % 4 == 0)
                {
                    p3++;
                }
            }
            double pAll = numbersCount;
            double p1Pro = (p1 / pAll) * 100;
            double p2Pro = (p2 / pAll) * 100;
            double p3Pro = (p3 / pAll) * 100;

            Console.WriteLine($"{p1Pro:f2}%");
            Console.WriteLine($"{p2Pro:f2}%");
            Console.WriteLine($"{p3Pro:f2}%");
        }
    }
}
