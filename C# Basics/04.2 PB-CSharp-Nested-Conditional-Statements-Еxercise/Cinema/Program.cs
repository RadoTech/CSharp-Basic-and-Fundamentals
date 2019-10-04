using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string filmType = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //logic
            double premiereType = 12.00;
            double normalType = 7.50;
            double discountType = 5.00;

            int fullHall = r * c;
            double fullHallIncome = 0.00;

            if (filmType == "Premiere")
            {
                fullHallIncome = fullHall * premiereType;
            }
            else if (filmType == "Normal")
            {
                fullHallIncome = fullHall * normalType;
            }
            else if (filmType == "Discount")
            {
                fullHallIncome = fullHall * discountType;
            }
            Console.WriteLine($"{fullHallIncome:f2} leva");
        }
    }
}
