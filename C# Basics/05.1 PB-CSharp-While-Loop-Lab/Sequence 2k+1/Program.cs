using System;

namespace Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int number = int.Parse(Console.ReadLine());

            //logic

            int n = 1;

            Console.WriteLine(n);

            while (n <= number)
            {
                n = (n * 2) + 1;

                if (n <= number)
                {

                    Console.WriteLine(n);
                }


            }


        }
    }
}
