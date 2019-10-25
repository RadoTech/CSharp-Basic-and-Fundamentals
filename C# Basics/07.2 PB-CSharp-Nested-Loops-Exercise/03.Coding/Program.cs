using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            string inputNum = Console.ReadLine();

            for (int i = inputNum.Length - 1; i >= 0; i--)
            {
                char currentDigit = inputNum[i];
                int currentDigitToNum = int.Parse(currentDigit.ToString());

                if (currentDigitToNum == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                for (int n = 1; n <= currentDigitToNum; n++)
                {
                    Console.Write((char)(currentDigitToNum + 33));
                }
                Console.WriteLine();
            }

        }
    }
}
