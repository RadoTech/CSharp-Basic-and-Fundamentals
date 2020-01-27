using System;

namespace sumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            if (lines == 0)
            {
                Console.WriteLine($"The sum equals: {sumDigits}");
            }
            else if (lines > 0)
            {
                char letter = char.Parse(Console.ReadLine());
                for (int i = 1; i <= lines; i++)
                {
                    int digit = letter;
                    sumDigits += digit;
                    if (i == lines)
                    {
                        break;
                    }
                    letter = char.Parse(Console.ReadLine());
                }
                Console.WriteLine($"The sum equals: {sumDigits}");
            }
        }
    }
}
