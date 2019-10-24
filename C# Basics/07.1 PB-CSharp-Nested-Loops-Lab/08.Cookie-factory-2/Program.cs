using System;

namespace CookieFactory2
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchForDay = int.Parse(Console.ReadLine());
            int counterBatch = 0;
            bool flour = false;
            bool eggs = false;
            bool sugar = false;
            bool endCommand = false;
            string input = "";

            while (counterBatch < batchForDay)
            {
                while (!endCommand)
                {
                    input = Console.ReadLine();
                    if (input == "flour")
                    {
                        flour = true;
                    }
                    else if (input == "eggs")
                    {
                        eggs = true;
                    }
                    else if (input == "sugar")
                    {
                        sugar = true;
                    }
                    else if (input == "Bake!")
                    {
                        endCommand = true;
                    }
                    if (endCommand && (!flour || !eggs || !sugar))
                    {
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        endCommand = false;
                    }
                }
                if (endCommand)
                {
                    counterBatch++;
                    flour = false;
                    sugar = false;
                    eggs = false;
                    endCommand = false;
                    Console.WriteLine($"Baking batch number {counterBatch}...");
                }
            }
        }
    }
}
