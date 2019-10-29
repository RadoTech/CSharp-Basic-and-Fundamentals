using System;

namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)

        {
            // read input usd
            double usd = double.Parse(Console.ReadLine());

            //logic(calculations)
            double usdRate = 1.79549;
            double bgn = usd * usdRate;

            //output(formated)
            Console.WriteLine($"{bgn:f2}");
        }
    }
}
