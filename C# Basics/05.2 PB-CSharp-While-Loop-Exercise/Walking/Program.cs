using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string stepsPerWalk = Console.ReadLine();
            int stepsCounter = 0;

            while (stepsPerWalk != "Going home")
            {
                stepsCounter += int.Parse(stepsPerWalk);
                if (stepsCounter >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    return;
                }
                stepsPerWalk = Console.ReadLine();
            }
            if (stepsPerWalk == "Going home")
            {
                stepsPerWalk = Console.ReadLine();
                stepsCounter += int.Parse(stepsPerWalk);
                if (stepsCounter >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
                else if (stepsCounter < 10000)
                {
                    int stepsLeft = 10000 - stepsCounter;
                    Console.WriteLine($"{stepsLeft} more steps to reach goal.");
                }
            }
        }
    }
}
