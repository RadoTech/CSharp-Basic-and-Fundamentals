using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //1.Дължина в см – цяло число в интервала [10 … 500]
            //2.Широчина в см – цяло число в интервала[10 … 300]
            //3.Височина в см – цяло число в интервала[10… 200]
            //4.Процент  – реално число в интервала[0.000 … 100.000]

            double lengthFishTank = double.Parse(Console.ReadLine());
            double widthFishTank = double.Parse(Console.ReadLine());
            double heightFishTank = double.Parse(Console.ReadLine());
            double percentOtherTools = double.Parse(Console.ReadLine());

            //logic
            //1 decimeter = 10 centimeters
            //1 liter = 1 decimeter3
            //formula = V = a * b * c

            double a = (lengthFishTank/10);
            double b = (widthFishTank/10);
            double c = (heightFishTank/10);

            double volume = a * b * c;
            double volumeWater = volume * (1 - (percentOtherTools / 100));

            //output

            Console.WriteLine($"{volumeWater:F3}");

        }
    }
}
