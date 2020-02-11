using System;

namespace GiftboxCoverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double sizeOfASide = double.Parse(Console.ReadLine());
            int sheetsOfPaper = int.Parse(Console.ReadLine());
            double areaCoveredSingleSheet = double.Parse(Console.ReadLine());

            //Logic
            double giftboxArea = Math.Pow(sizeOfASide, 2) * 6;
            double sumCovered = 0;
            for (int i = 1; i <= sheetsOfPaper; i++)
            {
                if (i % 3 == 0 )
                {
                    sumCovered += areaCoveredSingleSheet * 0.25;
                }
                else
                {
                    sumCovered += areaCoveredSingleSheet * 1;
                }
            }
            double percentBoxCovered = (sumCovered / giftboxArea) * 100;
            Console.WriteLine($"You can cover {percentBoxCovered:f2}% of the box.");
        }
    }
}
