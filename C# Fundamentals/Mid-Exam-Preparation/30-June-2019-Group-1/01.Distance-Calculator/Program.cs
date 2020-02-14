using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:
            int stepsMade = int.Parse(Console.ReadLine());//in cm.
            double stepLength = double.Parse(Console.ReadLine()); //in cm.
            int distanceToTravel = int.Parse(Console.ReadLine());//in m.
            //Logic                                                     
            double allStepsLen = ShortSteps(stepsMade, stepLength) + NormalSteps(stepsMade, stepLength);
            double percentDistanceTraveled = ((allStepsLen / 100) / distanceToTravel) * 100;
            Console.WriteLine($"You travelled {percentDistanceTraveled:f2}% of the distance!");
        }

        static double NormalSteps(int stepsMade, double stepLength)
        {
            int normalStepsMade = stepsMade - (stepsMade / 5);
            double normalStepsLength = normalStepsMade * stepLength;
            return normalStepsLength;
        }
        static double ShortSteps(int stepsMade, double stepLength)
        {
            int shortStepsMade = stepsMade / 5;
            double shortStepsLength = shortStepsMade * (stepLength * 0.7);
            return shortStepsLength;
        }
    }
}
