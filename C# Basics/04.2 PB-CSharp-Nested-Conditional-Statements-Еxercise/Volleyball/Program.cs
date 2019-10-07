using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string typeOfYear = Console.ReadLine();
            double bankHolidaysCount = double.Parse(Console.ReadLine());
            double weekendsHome = double.Parse(Console.ReadLine());

            //logic

            double weekendsPerYear = 48;
            double bankHolidaysPlay = (bankHolidaysCount / 3) * 2;

            double weekendsHomePlay = weekendsHome;

            double weekendsSofia = weekendsPerYear - weekendsHome;
            double weekendsSofiaFree = (weekendsSofia / 4) * 3;
            double weekendsSofiaPlay = weekendsSofiaFree;

            double leapYearRate = 1.15;

            double VolleyballDays = 0;

            if (typeOfYear == "leap")
            {
                VolleyballDays = ((bankHolidaysPlay + weekendsHomePlay + weekendsSofiaPlay) * leapYearRate);
            }
            else if (typeOfYear == "normal")
            {
                VolleyballDays = bankHolidaysPlay + weekendsHomePlay + weekendsSofiaPlay;
            }
            //output



            Console.WriteLine($"{Math.Floor(VolleyballDays)}");


        }
    }
}
