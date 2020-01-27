using System;

namespace triplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (int first = 1; first <= inputNumber; first++)
            {
                for (int second = 1; second <= inputNumber; second++)
                {
                    for (int third = 1; third <= inputNumber; third++)
                    {
                        char firstChar = (char)(first + 96);
                        char secondChar = (char)(second + 96);
                        char thirdChar = (char)(third + 96);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
