using System;

namespace Exercise3_2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //input x1,x2,y1,y2
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            //logic - calculation of length and height
            //calculation of area and perimeter
            double length = Math.Abs(x1 - x2);
            double height = Math.Abs(y1 - y2);

            double area = Math.Abs(length * height);
            double perimeter = Math.Abs(2 * (length + height));

            //output 
            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");


        }
    }
}
