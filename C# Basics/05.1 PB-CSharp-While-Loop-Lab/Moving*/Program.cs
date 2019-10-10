using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double widthFreeRoom = double.Parse(Console.ReadLine());
            double lengthFreeRoom = double.Parse(Console.ReadLine());
            double heightFreeRoom = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();

            //logic

            double VFreeRoom = widthFreeRoom * lengthFreeRoom * heightFreeRoom;
            double VOneBox = 1 * 1 * 1;
            double VBoxes = 0;
            string done = "Done";

            while (action != done)
            {
                VBoxes += (int.Parse(action)) * VOneBox;
                if (VFreeRoom < VBoxes)
                {
                    double cubicMetersNeeded = VBoxes - VFreeRoom;
                    Console.WriteLine($"No more free space! You need {cubicMetersNeeded:f0} Cubic meters more.");
                    return;
                }
                action = Console.ReadLine();
            }
            double cubicMetersLeft = VFreeRoom - VBoxes;
            Console.WriteLine($"{cubicMetersLeft:f0} Cubic meters left.");
        }
    }
}
