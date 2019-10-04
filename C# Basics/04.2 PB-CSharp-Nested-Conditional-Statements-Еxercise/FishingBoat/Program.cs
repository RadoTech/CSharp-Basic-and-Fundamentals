using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            int budgetGroup = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermansCount = int.Parse(Console.ReadLine());

            //logic

            string summer = "Summer";
            string spring = "Spring";
            string autumn = "Autumn";
            string winter = "Winter";

            double shipSpringPrice = 3000;
            double shipSummerAndAutumnPrice = 4200;
            double shipWinterPrice = 2600;

            double discount1 = 0.9;
            double discount2 = 0.85;
            double discount3 = 0.75;
            double discountEven = 0.95;

            bool isNotAutumnDiscount = ((!(season == autumn)) && (fishermansCount % 2 == 0));

            double shipPrice = 0.00;

            if (season == spring)
            {
                if (fishermansCount <= 6)
                {
                    shipPrice = shipSpringPrice * discount1;
                }
                else if (fishermansCount >= 7 && fishermansCount <= 11)
                {
                    shipPrice = shipSpringPrice * discount2;
                }
                else if (fishermansCount >= 12)
                {
                    shipPrice = shipSpringPrice * discount3;
                }
            }
            else if (season == summer || season == autumn)
            {
                if (fishermansCount <= 6)
                {
                    shipPrice = shipSummerAndAutumnPrice * discount1;
                }
                else if (fishermansCount >= 7 && fishermansCount <= 11)
                {
                    shipPrice = shipSummerAndAutumnPrice * discount2;
                }
                else if (fishermansCount >= 12)
                {
                    shipPrice = shipSummerAndAutumnPrice * discount3;
                }
            }
            else if (season == winter)
            {
                if (fishermansCount <= 6)
                {
                    shipPrice = shipWinterPrice * discount1;
                }
                else if (fishermansCount >= 7 && fishermansCount <= 11)
                {
                    shipPrice = shipWinterPrice * discount2;
                }
                else if (fishermansCount >= 12)
                {
                    shipPrice = shipWinterPrice * discount3;
                }
            }
            if (isNotAutumnDiscount)
            {
                shipPrice *= discountEven;
            }
            else
            {
                shipPrice = shipPrice;
            }
            double restMoney = Math.Abs(budgetGroup - shipPrice);

            //output
            if (budgetGroup >= shipPrice)
            {
                Console.WriteLine($"Yes! You have {restMoney:f2} leva left.");
            }
            else if (budgetGroup < shipPrice)
            {
                Console.WriteLine($"Not enough money! You need {restMoney:f2} leva.");
            }
            
        }
    }
}

