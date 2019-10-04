using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //logic

            string summer = "summer";
            string winter = "winter";

            double vacationPrice = 0.00;
            string destination = "Somewhere in...";
            string accommodation = "under the sky :D";

            double percentSummerBg = 0.3;
            double percentWinterBg = 0.7;
            double percentSummerBalkans = 0.4;
            double percentWinterBalkans = 0.8;
            double percentEU = 0.9;

            if (budget <= 100)
            {
                if (season == summer)
                {
                    vacationPrice = budget * percentSummerBg;
                    destination = "Bulgaria";
                    accommodation = "Camp";
                }
                else if (season == winter)
                {
                    vacationPrice = budget * percentWinterBg;
                    destination = "Bulgaria";
                    accommodation = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                if (season == summer)
                {
                    vacationPrice = budget * percentSummerBalkans;
                    destination = "Balkans";
                    accommodation = "Camp";
                }
                else if (season == winter)
                {
                    vacationPrice = budget * percentWinterBalkans;
                    destination = "Balkans";
                    accommodation = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                vacationPrice = budget * percentEU;
                destination = "Europe";
                accommodation = "Hotel";
            }

            //output

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accommodation} - {vacationPrice:f2}");
        
        }

    }
}
