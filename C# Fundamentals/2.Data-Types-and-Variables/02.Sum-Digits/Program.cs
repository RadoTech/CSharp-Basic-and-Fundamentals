using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sumDigits = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = (int)Char.GetNumericValue(number[i]);
                sumDigits += digit;
            }
            Console.WriteLine(sumDigits);
        }
    }
}
