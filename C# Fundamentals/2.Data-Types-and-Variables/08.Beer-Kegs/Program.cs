using System;

namespace beerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegCount = int.Parse(Console.ReadLine());
            string kegName = Console.ReadLine();
            double kegRadius = double.Parse(Console.ReadLine());
            int kegHeight = int.Parse(Console.ReadLine());
            decimal biggestKeg = 0.0M;
            string biggestKegName = string.Empty;
            for (int keg = 1; keg <= kegCount; keg++)
            {
                decimal kegVolume = (decimal)Math.PI * (decimal)Math.Pow(kegRadius, 2) * kegHeight;
                if (kegVolume > biggestKeg)
                {
                    biggestKeg = kegVolume;
                    biggestKegName = kegName; 
                }
                if (keg == kegCount)
                {
                    break;
                }
                kegName = Console.ReadLine();
                kegRadius = double.Parse(Console.ReadLine());
                kegHeight = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
