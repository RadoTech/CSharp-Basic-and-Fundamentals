using System;

namespace SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            double foodMoneyADay = double.Parse(Console.ReadLine());
            double souvenirsMoneyADay = double.Parse(Console.ReadLine());
            double hotelMoneyADay = double.Parse(Console.ReadLine());

            //Logic

            double fuelMoney = 4.20;
            double fuelMoneyLiters = (fuelMoney * 7);
            double fuelMoneyTotal = fuelMoneyLiters * 1.85;
            double foodMoneyTotal = foodMoneyADay * 3;
            double souvenirsMoneyTotal = souvenirsMoneyADay * 3;
            double hotelMoneyTotal = (hotelMoneyADay * 0.9) + (hotelMoneyADay * 0.85) + (hotelMoneyADay * 0.8);

            double moneyTotal = fuelMoneyTotal + foodMoneyTotal + souvenirsMoneyTotal + hotelMoneyTotal;

            //Output:

            Console.WriteLine($"Money needed: {moneyTotal:f2}");

        }
    }
}
