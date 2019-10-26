using System;

namespace ChristmasSweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double baklavaPriceKg = double.Parse(Console.ReadLine());
            double muffinsPriceKg = double.Parse(Console.ReadLine());
            double stolenKg = double.Parse(Console.ReadLine());
            double bonboniKg = double.Parse(Console.ReadLine());
            double biskvitiKg = double.Parse(Console.ReadLine());

            double stolenPriceKg = baklavaPriceKg * 1.6;
            double bonboniPricekg = muffinsPriceKg * 1.8;
            double biskvitiPriceKg = 7.50;

            double totalMoneyNeeded = (stolenPriceKg * stolenKg) + (bonboniPricekg * bonboniKg) + biskvitiPriceKg * (biskvitiKg);

            Console.WriteLine($"{totalMoneyNeeded:f2}");
        }
    }
}
