using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            string roomType = "";

            for (int f = floors; f > 0;f--)
            {
                
                for (int r = 0; r < rooms; r++)
                {
                    if (f % 2 == 0)
                    {
                        roomType = "O";
                        if (f == floors)
                        {
                            roomType = "L";
                        }
                    }
                    else if (f % 2 != 0)
                    {
                        roomType = "A";
                        if (f == floors)
                        {
                            roomType = "L";
                        }
                    }
                    Console.Write($"{roomType}{f}{r} ");
                }
                Console.Write("\r\n");
            }
        }
    }
}
