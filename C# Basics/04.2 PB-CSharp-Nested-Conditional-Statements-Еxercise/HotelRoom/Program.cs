using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            //logic

            double studioS1 = 50;
            double appS1 = 65;
            double studioS2 = 75.20;
            double appS2 = 68.70;
            double studioS3 = 76;
            double appS3 = 77;

            double discountStudioS1 = 0.95;
            double discountStudioS12 = 0.7;
            double discountStudioS2 = 0.8;
            double discountApp = 0.9;

            double priceStudio = 0.00;
            double priceApp = 0.00;

            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 14)
                {
                    priceStudio = (studioS1 * nights) * discountStudioS1;
                    priceApp = (appS1 * nights);
                }
                else if (nights > 14)
                {
                    priceStudio = (studioS1 * nights) * discountStudioS12;
                    priceApp = (appS1 * nights) * discountApp;
                }
                else
                {
                    priceStudio = (studioS1 * nights);
                    priceApp = (appS1 * nights);
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    priceStudio = (studioS2 * nights) * discountStudioS2;
                    priceApp = (appS2 * nights) * discountApp;
                }
                else
                {
                    priceStudio = (studioS2 * nights);
                    priceApp = (appS2 * nights);
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    priceStudio = (studioS3 * nights);
                    priceApp = (appS3 * nights) * discountApp;
                }
                else
                {
                    priceStudio = (studioS3 * nights);
                    priceApp = (appS3 * nights);
                }
            }

            //output

            Console.WriteLine($"Apartment: {priceApp:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");

        }
    }
}
