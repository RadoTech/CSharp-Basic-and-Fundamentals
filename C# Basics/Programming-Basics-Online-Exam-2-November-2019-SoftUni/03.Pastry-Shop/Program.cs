using System;

namespace PastryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            string sweetsType = Console.ReadLine();
            int sweetsCount = int.Parse(Console.ReadLine());
            int dayOfDecember = int.Parse(Console.ReadLine());

            //Logic

            double cakePrice1 = 24;
            double soufflePrice1 = 6.66;
            double baklavaPrice1 = 12.60;

            double cakePrice2 = 28.70;
            double soufflePrice2 = 9.80;
            double baklavaPrice2 = 16.98;

            double discountBGN1 = 0.15;
            double discountBGN2 = 0.25;
            double discountBGN3 = 0.10;

            double totalSweetsPrice = 0;

            if (sweetsType == "Cake")
            {
                if (dayOfDecember >= 1 && dayOfDecember <= 15)
                {
                    totalSweetsPrice = cakePrice1 * sweetsCount;
                }
                else if (dayOfDecember > 15 && dayOfDecember <= 24)
                {
                    totalSweetsPrice = cakePrice2 * sweetsCount;
                }
            }
            else if (sweetsType == "Souffle")
            {
                if (dayOfDecember >= 1 && dayOfDecember <= 15)
                {
                    totalSweetsPrice = soufflePrice1 * sweetsCount;
                }
                else if (dayOfDecember > 15 && dayOfDecember <= 24)
                {
                    totalSweetsPrice = soufflePrice2 * sweetsCount;
                }
            }
            else if (sweetsType == "Baklava")
            {
                if (dayOfDecember >= 1 && dayOfDecember <= 15)
                {
                    totalSweetsPrice = baklavaPrice1 * sweetsCount;
                }
                else if (dayOfDecember > 15 && dayOfDecember <= 24)
                {
                    totalSweetsPrice = baklavaPrice2 * sweetsCount;
                }
            }

            if (dayOfDecember <= 22)
            {
                if (totalSweetsPrice >= 100 && totalSweetsPrice <= 200)
                {
                    totalSweetsPrice = totalSweetsPrice - (totalSweetsPrice * discountBGN1);
                }
                else if (totalSweetsPrice > 200)
                {
                    totalSweetsPrice = totalSweetsPrice - (totalSweetsPrice * discountBGN2);
                }
            }
            if (dayOfDecember <= 15)
            {
                totalSweetsPrice = totalSweetsPrice - (totalSweetsPrice * discountBGN3);
            }
            Console.WriteLine($"{totalSweetsPrice:f2}");
        }
    }
}
