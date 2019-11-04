using System;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            //Logic:
            int substituteCounter = 0;

            for (int firstFirst = K; firstFirst <= 8; firstFirst++)
            {
                for (int secondFirst = 9; secondFirst >= L; secondFirst--)
                {
                    for (int firstSecond = M; firstSecond <= 8; firstSecond++)
                    {
                        for (int secondSecond = 9; secondSecond >= N; secondSecond--)
                        {
                            if ((firstFirst % 2 == 0) && (firstSecond % 2 == 0) && (secondFirst % 2 != 0) && (secondSecond % 2 != 0))
                            {
                                if ((firstFirst == firstSecond) && (secondFirst == secondSecond))
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                    
                                    
                                }
                                else if (true)
                                {
                                    Console.WriteLine($"{firstFirst}{secondFirst} - {firstSecond}{secondSecond}");
                                    substituteCounter++;
                                    if (substituteCounter == 6)
                                    {
                                        return;
                                    }
                                }
                                
                            }
                        }
                    }
                }

            }

        }
    }
}
