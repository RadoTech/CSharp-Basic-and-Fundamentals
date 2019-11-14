using System;

namespace GiftsFromSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            //Logic:

            for (int i = M; i >= N; i--)
            {
                if ((i % 2 == 0) && (i % 3 == 0))
                {
                    if (i == S)
                    {
                        return;
                    }
                    else
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}
