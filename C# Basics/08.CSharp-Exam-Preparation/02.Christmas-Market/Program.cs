using System;

namespace ChristmasMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double donationMoneyNeeded = double.Parse(Console.ReadLine());
            int fantasyBooksCount = int.Parse(Console.ReadLine());
            int horrorBooksCount = int.Parse(Console.ReadLine());
            int loveBooksCount = int.Parse(Console.ReadLine());

            //logic

            double fantasyBookPrice = 14.90;
            double horrorBookPrice = 9.80;
            double loveBookPrice = 4.30;

            double totalFantasyBookPrice = fantasyBooksCount * fantasyBookPrice;
            double totalHorrorBookPrice = horrorBooksCount * horrorBookPrice;
            double totalLoveBookPrice = loveBooksCount * loveBookPrice;

            double totalBooksMoney = ((totalFantasyBookPrice + totalHorrorBookPrice + totalLoveBookPrice)*0.8);

            if (totalBooksMoney >= donationMoneyNeeded)
            {
                if (totalBooksMoney > donationMoneyNeeded)
                {
                    double organisationFee = Math.Floor((totalBooksMoney - donationMoneyNeeded) * 0.1);
                    double donatedMoney = totalBooksMoney - organisationFee;
                    Console.WriteLine($"{donatedMoney:f2} leva donated.");
                    Console.WriteLine($"Sellers will receive {organisationFee} leva.");
                }
                else if (totalBooksMoney == donationMoneyNeeded)
                {
                    Console.WriteLine($"{totalBooksMoney}");
                }
            }
            else if (totalBooksMoney < donationMoneyNeeded)
            {
                double moneyNeeded = donationMoneyNeeded - totalBooksMoney;
                Console.WriteLine($"{moneyNeeded:f2} money needed.");
            }
        }
    }
}
