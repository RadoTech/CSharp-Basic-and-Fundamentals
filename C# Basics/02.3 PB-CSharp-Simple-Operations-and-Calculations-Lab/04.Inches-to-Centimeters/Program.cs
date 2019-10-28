using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double cmRate = 2.54;
            double calculation = inch * cmRate;

            Console.WriteLine($"{calculation:F2}");
        }
    }
}
