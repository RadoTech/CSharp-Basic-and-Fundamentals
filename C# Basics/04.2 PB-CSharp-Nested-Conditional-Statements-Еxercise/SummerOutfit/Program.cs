using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double degreeCelsius = double.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();

            //logic
            string outfit = "blank";
            string shoes = "blank";

            bool cold = (degreeCelsius >= 10 && degreeCelsius <= 18);
            bool moderate = (degreeCelsius > 18 && degreeCelsius <= 24);
            bool warm = (degreeCelsius >= 25);

            if (cold)
            {
                if (partOfTheDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (partOfTheDay == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (moderate)
            {
                if (partOfTheDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partOfTheDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (warm)
            {
                if (partOfTheDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfTheDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (partOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {degreeCelsius} degrees, get your {outfit} and {shoes}.");
        }
    }
}
