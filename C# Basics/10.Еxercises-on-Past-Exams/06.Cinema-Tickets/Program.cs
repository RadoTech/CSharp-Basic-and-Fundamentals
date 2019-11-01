using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string filmName = Console.ReadLine();
            int seatsFree = int.Parse(Console.ReadLine());

            //logic
            double standardCount = 0;
            double studnetCount = 0;
            double kidCount = 0;
            int seatCount = 0;
            double currentTicketPercent = 0;
            string currentFilmName;
            double allTickets = 0;
            double allSeats = 0;


            while (filmName != "Finish")
            {
                for (int i = 1; i <= seatsFree; i++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "standard")
                    {
                        standardCount++;
                        seatCount++;
                    }
                    else if (ticketType == "student")
                    {
                        studnetCount++;
                        seatCount++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidCount++;
                        seatCount++;
                    }
                    else if (ticketType == "End")
                    {
                        break;
                    }
                }
                allSeats = seatCount;
                allTickets = standardCount + studnetCount + kidCount;
                currentTicketPercent = (allSeats / seatsFree) * 100;
                currentFilmName = filmName;
                Console.WriteLine($"{filmName} - {currentTicketPercent:f2}% full.");
                seatsFree = 0;
                seatCount = 0;
                filmName = Console.ReadLine();
                if (filmName == "Finish")
                {
                    break;
                }
                seatsFree = int.Parse(Console.ReadLine());
            }
            standardCount = (standardCount / allTickets) * 100;
            studnetCount = (studnetCount / allTickets) * 100;
            kidCount = (kidCount / allTickets) * 100;
            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{studnetCount:f2}% student tickets.");
            Console.WriteLine($"{standardCount:f2}% standard tickets.");
            Console.WriteLine($"{kidCount:f2}% kids tickets.");
        }
    }
}
