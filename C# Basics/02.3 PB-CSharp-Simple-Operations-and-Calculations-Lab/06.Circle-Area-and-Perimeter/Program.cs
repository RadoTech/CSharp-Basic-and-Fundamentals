using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double r = double.Parse(Console.ReadLine());

            //logic
            //Circle Perimeter = S = π.r.r
            //Circle Area = P = 2.π.r


            double S = Math.PI * (r * r);
            double P = 2 * Math.PI * r;

            //output
            Console.WriteLine($"{S:F2}");
            Console.WriteLine($"{P:F2}");
        }
    }
}
