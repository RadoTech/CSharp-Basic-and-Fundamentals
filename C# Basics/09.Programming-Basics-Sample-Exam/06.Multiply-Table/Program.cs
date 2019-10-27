using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:
            string inputNumber = Console.ReadLine();

            //Logic:

            double firstNumber = 0;
            double secondNumber = 0;
            double thirdNumber = 0;

            for (int i = 0; i < inputNumber.Length; i++)
            {
                firstNumber = Char.GetNumericValue(inputNumber[0]);
                secondNumber = Char.GetNumericValue(inputNumber[1]);
                thirdNumber = Char.GetNumericValue(inputNumber[2]);
            }

            for (int p = 1; p <= thirdNumber; p++)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    for (int k = 1; k <= firstNumber; k++)
                    {
                        Console.WriteLine($"{p} * {j} * {k} = {p * j * k};");
                    }
                }
            }
        }
    }
}
