using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            //logic
            double rosesPrice = 5;
            double dahliasPrice = 3.8;
            double tulipsPrice = 2.8;
            double narcissusPrice = 3;
            double gladiolusPrice = 2.5;

            double discountRoses = 0.9;
            double discountDahlias = 0.85;
            double discountTulips = 0.85;
            double surchargeNarcissus = 1.15;
            double surchargeGladiolus = 1.2;

            bool discount = ((flowersType == "Roses") && flowersCount > 80 ||
                            (flowersType == "Dahlias") && flowersCount > 90 ||
                            (flowersType == "Tulips") && flowersCount > 80);

            bool surcharge = ((flowersType == "Narcissus") && flowersCount < 120 ||
                             (flowersType == "Gladiolus") && flowersCount < 80);

            double totalPrice = 0.00;

            if (flowersType == "Roses")
            {
                if (discount)
                {
                    totalPrice = (rosesPrice * flowersCount) * discountRoses;
                }
                else
                {
                    totalPrice = (rosesPrice * flowersCount);
                }

            }
            else if (flowersType == "Dahlias")
            {
                if (discount)
                {
                    totalPrice = (dahliasPrice * flowersCount) * discountDahlias;
                }
                else
                {
                    totalPrice = (dahliasPrice * flowersCount);
                }
            }
            else if (flowersType == "Tulips")
            {
                if (discount)
                {
                    totalPrice = (tulipsPrice * flowersCount) * discountTulips;
                }
                else
                {
                    totalPrice = (tulipsPrice * flowersCount);
                }
            }
            else if (flowersType == "Narcissus")
            {
                if (surcharge)
                {
                    totalPrice = (narcissusPrice * flowersCount) * surchargeNarcissus;
                }
                else
                {
                    totalPrice = (narcissusPrice * flowersCount);
                }
            }
            else if (flowersType == "Gladiolus")
            {
                if (surcharge)
                {
                    totalPrice = (gladiolusPrice * flowersCount) * surchargeGladiolus;
                }
                else
                {
                    totalPrice = (gladiolusPrice * flowersCount);
                }
            }

            double restMoney = Math.Abs(budget - totalPrice);

            //output

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {restMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {restMoney:f2} leva more.");
            }
        }
    }
}
