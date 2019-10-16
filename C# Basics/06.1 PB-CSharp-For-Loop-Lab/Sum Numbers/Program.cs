using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int numbersSum = 0;

            for (int i = 1; i <= numbersCount; i++)
            {

                int currentNumber = int.Parse(Console.ReadLine());
                numbersSum += currentNumber;
            }

            Console.WriteLine(numbersSum);
        }
    }
}
