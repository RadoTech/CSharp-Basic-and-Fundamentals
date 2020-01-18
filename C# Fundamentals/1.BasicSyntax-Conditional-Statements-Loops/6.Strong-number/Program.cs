using System;

namespace strongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            string inputNumToString = inputNum.ToString();
            int currentNum = 0;
            int currentFactorial = 1;
            int sumFactorial = 0;
            for (int i = 0; i < inputNumToString.Length ; i++)
            {
                currentNum = (int)Char.GetNumericValue(inputNumToString[i]);

                for (int j = 1; j <= currentNum; j++)
                {
                    currentFactorial *= j;
                }
                sumFactorial += currentFactorial;
                currentFactorial = 1;
            }
            if (sumFactorial == inputNum)
            {
                Console.WriteLine("yes");
            }
            else if (sumFactorial != inputNum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
