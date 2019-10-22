using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int firstNumber = 1; firstNumber <= 10; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <= 10; secondNumber++)
                {
                    int result = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                }
            }
        }
    }
}
