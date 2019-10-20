using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 1; i <= numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber >= 1 && currentNumber < 200)
                {
                    p1++;
                }
                else if (currentNumber >= 200 && currentNumber < 400)
                {
                    p2++;
                }
                else if (currentNumber >= 400 && currentNumber < 600)
                {
                    p3++;
                }
                else if (currentNumber >= 600 && currentNumber < 800)
                {
                    p4++;
                }
                else if (currentNumber >= 800 && currentNumber <= 1000)
                {
                    p5++;
                }
            }
            double pAll = p1 + p2 + p3 + p4 + p5;

            double p1Pro = (p1 / pAll) * 100;
            double p2Pro = (p2 / pAll) * 100;
            double p3Pro = (p3 / pAll) * 100;
            double p4Pro = (p4 / pAll) * 100;
            double p5Pro = (p5 / pAll) * 100;

            Console.WriteLine($"{p1Pro:f2}%");
            Console.WriteLine($"{p2Pro:f2}%");
            Console.WriteLine($"{p3Pro:f2}%");
            Console.WriteLine($"{p4Pro:f2}%");
            Console.WriteLine($"{p5Pro:f2}%");   
        }
    }
}
