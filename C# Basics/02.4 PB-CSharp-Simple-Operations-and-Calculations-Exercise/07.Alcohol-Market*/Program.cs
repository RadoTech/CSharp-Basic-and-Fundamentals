using System;

namespace Exercise7AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //1.Цена на уискито в лева – реално число в интервала [0.00 … 10000.00]
            //2.Количество на бирата в литри – реално число в интервала[0.00 … 1 0000.00]
            //3.Количество на виното в литри – реално число в интервала[0.00 … 10000.00]
            //4.Количество на ракията в литри – реално число в интервала[0.00 … 10000.00]
            //5.Количество на уискито в литри – реално число в интервала[0.00 … 10000.00]

            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerAmount = double.Parse(Console.ReadLine());
            double wineAmount = double.Parse(Console.ReadLine());
            double rakiAmount = double.Parse(Console.ReadLine());
            double whiskeyAmount = double.Parse(Console.ReadLine());

            //logic
            //•	цената на ракията е на половина по-ниска от тази на уискито;
            //•	цената на виното е с 40 % по - ниска от цената на ракията;
            //•	цената на бирата е с 80 % по - ниска от цената на ракията.

            //rakiPrice = 0.5 * whiskeyPrice
            //winePrice = 0.6 * rakiPrice
            //beerPrice = 0.2 * rakiPrice

            //from whiskey
            double rakiRate = 0.5;
            //from raki
            double wineRate = 0.6;
            double beerRate = 0.2;

            double rakiPrice = whiskeyPrice * rakiRate;
            double winePrice = rakiPrice * wineRate;
            double beerPrice = rakiPrice * beerRate;

            double totalSumWhiskey = whiskeyAmount * whiskeyPrice;
            double totalSumRaki = rakiAmount * rakiPrice;
            double totalSumWine = wineAmount * winePrice;
            double totalSumBeer = beerAmount * beerPrice;

            double totalSumAllDrinks = totalSumWhiskey + totalSumRaki + totalSumWine + totalSumBeer;

            //output
            //Print out the money needed to by all drinks formated 2 symbols after , 

            Console.WriteLine($"{totalSumAllDrinks:F2}");

        }
    }
}
