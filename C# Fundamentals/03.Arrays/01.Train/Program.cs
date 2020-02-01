using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] wagons = new int[wagonsCount];
            int passengersSum = 0;
            string passengersRow = string.Empty;
            foreach (var i in wagons)
            {
                int passengers = int.Parse(Console.ReadLine());
                passengersRow += passengers + " ";
                passengersSum += passengers;
            }
            Console.WriteLine(passengersRow);
            Console.WriteLine(passengersSum);
        }
    }
}
