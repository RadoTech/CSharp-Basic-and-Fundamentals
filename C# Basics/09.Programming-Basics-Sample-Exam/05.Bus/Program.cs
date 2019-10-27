using System;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            int passengersCountStart = int.Parse(Console.ReadLine());
            int stopsCount = int.Parse(Console.ReadLine());

            //Logic:
            int controllers = 0;
            int newPassengersIn = 0;
            int newPassengersOut = 0;

            for (int i = 1; i <= stopsCount; i++)
            {
                if (i % 2 != 0)
                {
                    controllers = 2;
                }
                else if (i % 2 == 0)
                {
                    controllers = 0;
                }
                newPassengersOut = int.Parse(Console.ReadLine());
                newPassengersIn = int.Parse(Console.ReadLine());
                passengersCountStart -= newPassengersOut;
                passengersCountStart += newPassengersIn;
            }

            Console.WriteLine($"The final number of passengers is : {passengersCountStart + controllers}");
        }
    }
}
