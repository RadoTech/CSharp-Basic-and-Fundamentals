using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 1; i <= numbersCount; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());

                if (maxNumber < currentNumber)
                {
                    maxNumber = currentNumber;
                }
                if (minNumber > currentNumber)
                {
                    minNumber = currentNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
