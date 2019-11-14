using System;

namespace BirdFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            int oneEggPrice = int.Parse(Console.ReadLine());
            int hensCountFirstMonth = int.Parse(Console.ReadLine());
            int hensAddedSecondMonth = int.Parse(Console.ReadLine());
            int hensAddedThirdMonth = int.Parse(Console.ReadLine());

            //Logic:

            int eggsFirstMonth = hensCountFirstMonth * 20;
            int eggsSecondMonth = (hensCountFirstMonth + hensAddedSecondMonth) * 20;
            int eggsThirdMonth = (hensCountFirstMonth + hensAddedSecondMonth + hensAddedThirdMonth) * 20;

            int totalEggs = eggsFirstMonth + eggsSecondMonth + eggsThirdMonth;

            double totalRobustEggs = Math.Floor(totalEggs * 0.96);

            double totalMoneyCoins = totalRobustEggs * oneEggPrice;
            double totalMoneyBGN = Math.Floor(totalMoneyCoins / 100);

            Console.WriteLine($"Profit: {totalMoneyBGN} Lv.");

        }
    }
}
