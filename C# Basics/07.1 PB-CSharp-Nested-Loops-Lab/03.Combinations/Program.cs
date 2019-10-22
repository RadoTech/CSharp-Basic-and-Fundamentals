using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int combinationsCount = 0;

            for (int firstNumber = 0; firstNumber <= n; firstNumber++)
            {
                for (int secondNumber = 0; secondNumber <= n; secondNumber++)
                {
                    for (int thirdNumber = 0; thirdNumber <= n; thirdNumber++)
                    {
                        int sum = firstNumber + secondNumber + thirdNumber;

                        if (sum == n)
                        {
                            combinationsCount++;
                        }
                    }
                }
            }
            Console.WriteLine($"{combinationsCount}");
        }
    }
}
