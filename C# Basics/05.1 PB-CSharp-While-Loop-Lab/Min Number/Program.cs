using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int count = 1;
            int n = 0;
            int minNumber = int.MaxValue;

            while (count <= number)
            {
                n = int.Parse(Console.ReadLine());

                if (n < minNumber)
                {
                    minNumber = n;
                }

                count++;
            }
            Console.WriteLine(minNumber);
        }
    }
}
