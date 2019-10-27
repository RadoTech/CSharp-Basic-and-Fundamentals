using System;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            double shipW = double.Parse(Console.ReadLine());
            double shipL = double.Parse(Console.ReadLine());
            double shipH = double.Parse(Console.ReadLine());
            double astronautsAverageH = double.Parse(Console.ReadLine());

            //Logic:

            double shipV = shipW * shipL * shipH;
            double astronautRoom = 2 * 2 * (astronautsAverageH + 0.4);
            double astronautsAllRooms = Math.Floor(shipV / astronautRoom);

            //Output:

            if (astronautsAllRooms >= 3 && astronautsAllRooms <= 10)
            {
                Console.WriteLine($"The spacecraft holds {astronautsAllRooms} astronauts.");
            }
            else if (astronautsAllRooms < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astronautsAllRooms > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
