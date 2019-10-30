using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double calculation = a * a;
                Console.WriteLine($"{calculation:F3}");

            }
            else if (shape == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double calculation = a * b;
                Console.WriteLine($"{calculation:F3}");
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double calculation = Math.PI * Math.Pow(r, 2);
                Console.WriteLine($"{calculation:F3}");
            }
            else if (shape == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double calculation = ((a * b) / 2);
                Console.WriteLine($"{calculation:F3}");
            }
        }
    }
}
