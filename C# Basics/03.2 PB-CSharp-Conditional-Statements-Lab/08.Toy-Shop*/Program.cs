using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacation = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int speakingPuppets = int.Parse(Console.ReadLine());
            int teddybears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzelsPrice = 2.60;
            double speakingPuppetsPrice = 3.00;
            double teddybearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            double basket = (puzzels * puzzelsPrice) + (speakingPuppets * speakingPuppetsPrice) + (teddybears * teddybearPrice) + (minions * minionPrice) + (trucks * truckPrice);
            int toysCount = puzzels + speakingPuppets + teddybears + minions + trucks;
            double discount = basket * 0.25;
            double rent = 0.1;
            double money = (basket - discount) - ((basket - discount) * rent);
            double money2 = basket - (basket * rent);
            double win = money - vacation;
            double win2 = money2 - vacation;


            if (toysCount >= 50 && win >= 0)
            {
                Console.WriteLine($"Yes! {win:F2} lv left.");
            }
            else if (toysCount >= 50 && win < 0)
                Console.WriteLine($"Not enough money! {Math.Abs(win):F2} lv needed.");

            else if (toysCount < 50 && win2 >= 0)
            {
                Console.WriteLine($"Yes! {win2:F2} lv left.");
            }
            else if (toysCount < 50 && win2 < 0)
            {
                Console.WriteLine($"Not enough money! {Math.Abs(win2):F2} lv needed.");
            }
        }

    }
}
