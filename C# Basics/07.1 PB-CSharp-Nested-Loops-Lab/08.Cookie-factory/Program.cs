using System;

namespace CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchCount = int.Parse(Console.ReadLine());

            int flourCount = 0;
            int sugarCount = 0;
            int eggsCount = 0;
            int bakeCount = 0;
            string command = "";

            for (int batch = 1; batch <= batchCount; batch++)
            {
                command = Console.ReadLine();
                while (command != "Bake!")
                {
                    if (command == "flour")
                    {
                        flourCount++;
                    }
                    else if (command == "eggs")
                    {
                        eggsCount++;
                    }
                    else if (command == "sugar")
                    {
                        sugarCount++;
                    }
                    command = Console.ReadLine();
                    if (command == "Bake!")
                    {
                        if (sugarCount >= 1 && eggsCount >= 1 && flourCount >= 1)
                        {
                            bakeCount++;
                            Console.WriteLine($"Baking batch number {bakeCount}...");
                            sugarCount = 0;
                            eggsCount = 0;
                            flourCount = 0;
                        }
                        else if (sugarCount < 1 || eggsCount < 1 || flourCount < 1)
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                            batch--;
                        }
                    }
                }
            }
        }
    }
}
