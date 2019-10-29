using System;

namespace Exercise5DancingHall
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //input
            //1.L – дължина на залата в метри – реално число в интервала  [10.00 … 100.00]
            //2.W – ширина на залата в метри – реално число в интервала[10.00 … 100.00]
            //3.А – страна на гардероба в метри – реално число в интервала[2.00… 20.00]

            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            //logic
            //1 wardrobe - quadrate(side A)
            //1 bench - rectangle(0.1*Hall area)
            //1 dancer = area 40 sm2 + 7000 sm2

            double wardrobeArea = (A * 100) * (A * 100);
            double oneDancerArea = 40 + 7000;
            double hallArea = (L * 100) * (W * 100);
            double benchArea = hallArea * 0.1;
            double usableHallArea = (hallArea - wardrobeArea - benchArea) / oneDancerArea;

            //output
            //int formated with ConsoleWriteLine(int.MinValue)

            Console.WriteLine(Math.Floor(usableHallArea));
            */

            //input
            //1.L – дължина на залата в метри – реално число в интервала  [10.00 … 100.00]
            //2.W – ширина на залата в метри – реално число в интервала[10.00 … 100.00]
            //3.А – страна на гардероба в метри – реално число в интервала[2.00… 20.00]

            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            //logic
            //1 wardrobe - quadrate(side A)
            //1 bench - rectangle(0.1*Hall area)
            //1 dancer = area 40 sm2 + 7000 sm2
            //1 m2 = 10 000 sm2

            double wardrobeArea = A * A;
            double oneDancerArea = 0.004 + 0.7;
            double hallArea = L * W;
            double benchArea = hallArea * 0.1;
            double usableHallArea = (hallArea - wardrobeArea - benchArea) / oneDancerArea;

            //output
            //int formated with ConsoleWriteLine(int.MinValue)

            Console.WriteLine(Math.Floor(usableHallArea));


        }
    }
}
