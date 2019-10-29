using System;

namespace Exercise4TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //pokrivka - rectangle ; kare - quadrat; count the same. 
            //pokrivka + 0.30 cm from each corner of the table;
            //kare = 0.5 from the length of the table
            //prise in bgn and usd; sq m plat = 7$ pokrivka and 9$ kare;
            //usdRate 1.85 bgn
            //input 1. count of rectangle tables int [0 - 500]
            //input 2. lenght of rectange tables in meters - Math.Abs [0.00 - 3.00]
            //input 3. weight of the retangle tables in meters - Math.Abs [0.00 - 3.00]

            //input
            double tablesCount = double.Parse(Console.ReadLine());
            double tablesLength = double.Parse(Console.ReadLine());
            double tablesWidth = double.Parse(Console.ReadLine());

            //logic

            double pokrivkaCount = tablesCount;
            double kareCount = tablesCount;

            double platPricePokrivaUSD = 7;
            double platPriceKareUSD = 9;
            double pokrivkaPrice = ((tablesLength + (2 * 0.30)) * (tablesWidth + (2 * 0.30))*platPricePokrivaUSD);
            double karePrice = (((tablesLength / 2) * (tablesLength / 2)) * platPriceKareUSD);
            double bgnRate = 1.85;

            double pokrivkaPriceTotalUSD = pokrivkaPrice * pokrivkaCount;
            double karePriceTotalUSD = karePrice * kareCount;

            double basketUSD = pokrivkaPriceTotalUSD + karePriceTotalUSD;
            double basketBGN = (pokrivkaPriceTotalUSD + karePriceTotalUSD)*bgnRate;

            //output 1. "{prise in USD} USD"
            //output 2. "{prise in BGN} BGN"

            Console.WriteLine($"{basketUSD:F2} USD");
            Console.WriteLine($"{basketBGN:F2} BGN");
            
        }
    }
}
