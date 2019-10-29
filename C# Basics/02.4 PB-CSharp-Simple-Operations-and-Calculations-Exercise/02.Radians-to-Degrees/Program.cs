using System;

namespace Exercise2RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //read corner in radians(rad)
            double rad = double.Parse(Console.ReadLine());

            //logic transfer rad in degrees (deg) deg = rad * 180/Math.PI
            double radDegRate = 180 / Math.PI;
            double deg = rad * radDegRate;


            //print out formated with Math.Round()
            Console.WriteLine(Math.Round(deg));

        }
    }
}
