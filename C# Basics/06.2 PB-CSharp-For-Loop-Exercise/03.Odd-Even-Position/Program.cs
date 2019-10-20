using System;

namespace ForOddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCounts = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= numberCounts; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                    if (currentNumber > evenMax)
                    {
                        evenMax = currentNumber;
                    }
                    if (currentNumber < evenMin)
                    {
                        evenMin = currentNumber;
                    }
                }
                else if (i % 2 != 0)
                {
                    oddSum += currentNumber;
                    if (currentNumber > oddMax)
                    {
                        oddMax = currentNumber;
                    }
                    if (currentNumber < oddMin)
                    {
                        oddMin = currentNumber;
                    }
                }

            }
            if (oddMin == double.MaxValue || oddMax == double.MinValue)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            if (evenMin == double.MaxValue || evenMax == double.MinValue)
            {
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
