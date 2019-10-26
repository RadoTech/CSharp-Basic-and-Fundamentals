using System;

namespace WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            string championshipStage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());
            char photosTrophy = char.Parse(Console.ReadLine());

            //Logic

            double allTicketsSum = 0;

            if (championshipStage == "Quarter final")
            {
                if (ticketType == "Standard")
                {
                    allTicketsSum = ticketsCount * 55.50;
                }
                else if (ticketType == "Premium")
                {
                    allTicketsSum = ticketsCount * 105.20;
                }
                else if (ticketType == "VIP")
                {
                    allTicketsSum = ticketsCount * 118.90;
                }
            }
            else if (championshipStage == "Semi final")
            {
                if (ticketType == "Standard")
                {
                    allTicketsSum = ticketsCount * 75.88;
                }
                else if (ticketType == "Premium")
                {
                    allTicketsSum = ticketsCount * 125.22;
                }
                else if (ticketType == "VIP")
                {
                    allTicketsSum = ticketsCount * 300.40;
                }
            }
            else if (championshipStage == "Final")
            {
                if (ticketType == "Standard")
                {
                    allTicketsSum = ticketsCount * 110.10;
                }
                else if (ticketType == "Premium")
                {
                    allTicketsSum = ticketsCount * 160.66;
                }
                else if (ticketType == "VIP")
                {
                    allTicketsSum = ticketsCount * 400;
                }
            }

            double totalSum = 0;
            int totalPhotosSum = 0;

            if (allTicketsSum > 4000)
            {
                totalSum = allTicketsSum * 0.75;
            }
            else if (allTicketsSum > 2500)
            {
                if (photosTrophy == 'Y')
                {
                    totalPhotosSum = ticketsCount * 40;
                }
                totalSum = (allTicketsSum * 0.9) + totalPhotosSum;
            }
            else if (allTicketsSum <= 2500)
            {
                if (photosTrophy == 'Y')
                {
                    totalPhotosSum = ticketsCount * 40;
                }
                totalSum = allTicketsSum + totalPhotosSum;
            }

            //Output
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
