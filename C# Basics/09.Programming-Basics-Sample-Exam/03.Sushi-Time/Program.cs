using System;

namespace SushiTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            string sushiType = Console.ReadLine();
            string restaurantName = Console.ReadLine();
            int portiontsCount = int.Parse(Console.ReadLine());
            char delivery = char.Parse(Console.ReadLine());

            //Logic:

            double sushiPrice = 0;

            if (restaurantName == "Sushi Zone")
            {
                if (sushiType == "sashimi")
                {
                    sushiPrice = 4.99;
                }
                else if (sushiType == "maki")
                {
                    sushiPrice = 5.29;
                }
                else if (sushiType == "uramaki")
                {
                    sushiPrice = 5.99;
                }
                else if (sushiType == "temaki")
                {
                    sushiPrice = 4.29;
                }
            }
            else if (restaurantName == "Sushi Time")
            {
                if (sushiType == "sashimi")
                {
                    sushiPrice = 5.49;
                }
                else if (sushiType == "maki")
                {
                    sushiPrice = 4.69;
                }
                else if (sushiType == "uramaki")
                {
                    sushiPrice = 4.49;
                }
                else if (sushiType == "temaki")
                {
                    sushiPrice = 5.19;
                }
            }
            else if (restaurantName == "Sushi Bar")
            {
                if (sushiType == "sashimi")
                {
                    sushiPrice = 5.25;
                }
                else if (sushiType == "maki")
                {
                    sushiPrice = 5.55;
                }
                else if (sushiType == "uramaki")
                {
                    sushiPrice = 6.25;
                }
                else if (sushiType == "temaki")
                {
                    sushiPrice = 4.75;
                }
            }
            else if (restaurantName == "Asian Pub")
            {
                if (sushiType == "sashimi")
                {
                    sushiPrice = 4.50;
                }
                else if (sushiType == "maki")
                {
                    sushiPrice = 4.80;
                }
                else if (sushiType == "uramaki")
                {
                    sushiPrice = 5.50;
                }
                else if (sushiType == "temaki")
                {
                    sushiPrice = 5.50;
                }
            }
            else
            {
                Console.WriteLine($"{restaurantName} is invalid restaurant!");
                return;
            }

            double sushiAllPortionsPrice = sushiPrice * portiontsCount;

            double deliveryPrice = 0;

            if (delivery == 'Y')
            {
                deliveryPrice = sushiAllPortionsPrice * 0.2;
            }
            else if (delivery == 'N')
            {
                deliveryPrice = 0;
            }

            double totalPrice = Math.Ceiling(sushiAllPortionsPrice + deliveryPrice);

            //Output:
            Console.WriteLine($"Total price: {totalPrice} lv.");
        }
    }
}
