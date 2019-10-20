using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());
            int sumPairs = 0;
            string result = "N/A";
            int maxDiff = 0;

            for (int i = 1; i <= pairsCount; i++)
            {
                int currentPairPartOne = int.Parse(Console.ReadLine());
                int currentPairPartTwo = int.Parse(Console.ReadLine());
                if ((currentPairPartOne + currentPairPartTwo) == sumPairs)
                {
                    result = "Yes";
                }
                else
                {
                    result = "No";
                    maxDiff = Math.Abs((currentPairPartOne + currentPairPartTwo) - sumPairs);
                }
                sumPairs = currentPairPartOne + currentPairPartTwo;
            }
            if (result == "Yes"|| pairsCount == 1)
            {
                Console.WriteLine($"Yes, value={sumPairs}");
            }
            else if (result == "No")
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
