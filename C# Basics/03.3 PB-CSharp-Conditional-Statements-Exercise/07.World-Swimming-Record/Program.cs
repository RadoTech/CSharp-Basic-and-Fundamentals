using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //in seconds
            double worldRecord = double.Parse(Console.ReadLine());
            //in meters
            double distance = double.Parse(Console.ReadLine());
            //in seconds
            double timeOneMeter = double.Parse(Console.ReadLine());

            //logic
            double waterResistance = 12.5;
            double waterResistanceDistance = 15;
            double realSpeedCorrection = (Math.Floor(distance/waterResistanceDistance)*waterResistance);
            double ivansTime = (distance * timeOneMeter) + realSpeedCorrection;
            double timeDifference = worldRecord - ivansTime;

            //output

            if (ivansTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivansTime:F2} seconds.");
            }
            else if (ivansTime >= worldRecord)
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(timeDifference):F2} seconds slower.");
            }
        }
    }
}
