using System;

namespace pokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); //power
            double power = (double)N * 0.5D;
            int M = int.Parse(Console.ReadLine()); //distance
            int Y = byte.Parse(Console.ReadLine()); //exhaustion Factor
            int pokesCount = 0;
            while (N >= M)
            {
                N -= M;
                pokesCount++;
                if (N == power && Y > 0)
                {
                    N /= Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(pokesCount);
        }
    }
}
