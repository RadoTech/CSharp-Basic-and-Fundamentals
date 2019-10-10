using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int count = 1;
            int n = 0;
            int maxNumber = int.MinValue;

            while (number >= count)
            {
                n = int.Parse(Console.ReadLine());
                if (n > maxNumber)
                {
                    maxNumber = n;
                }
                count++;

            }
            Console.WriteLine(maxNumber);

        }
    }
}
