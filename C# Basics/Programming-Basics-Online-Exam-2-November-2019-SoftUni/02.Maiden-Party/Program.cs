using System;

namespace MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            double maidenPartyPrice = double.Parse(Console.ReadLine());
            int loveLettersCount = int.Parse(Console.ReadLine());
            int waxRosesCount = int.Parse(Console.ReadLine());
            int keyChainsCount = int.Parse(Console.ReadLine());
            int cartoonsCount = int.Parse(Console.ReadLine());
            int luckSurprisesCount = int.Parse(Console.ReadLine());

            //Logic:

            double totalItemsSum = ((loveLettersCount * 0.6) + (waxRosesCount * 7.2) + (keyChainsCount * 3.6) + (cartoonsCount * 18.2) + (luckSurprisesCount * 22));
            int totalItemsCount = loveLettersCount + waxRosesCount + keyChainsCount + cartoonsCount + luckSurprisesCount;
            double discount = 0;

            if (totalItemsCount >= 25)
            {
                discount = totalItemsSum * 0.35;
                totalItemsSum *= 0.65;
                
            }

            double hosting = 0.1;
            double totalRevenue = totalItemsSum - (totalItemsSum * hosting);

            if (totalRevenue >= maidenPartyPrice)
            {
                Console.WriteLine($"Yes! {(totalRevenue - maidenPartyPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(maidenPartyPrice - totalRevenue):f2} lv needed.");
            }
        }
    }
}
