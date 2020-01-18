using System;

namespace rageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            int trashedHeadset = 0;
            int trashedMouse = 0;
            int trashedKeyboard = 0;
            int trashedKeyMarker = 0;
            int trashedDisplay = 0;
            for (int lostGame = 1; lostGame <= lostGamesCount; lostGame++)
            {
                if (lostGame % 2 == 0)
                {
                    trashedHeadset++;
                }
                if (lostGame % 3 == 0)
                {
                    trashedMouse++;
                }
                if (lostGame % 2 == 0 && lostGame % 3 == 0)
                {
                    trashedKeyboard++;
                    trashedKeyMarker++;
                }
                if (trashedKeyMarker == 2)
                {
                    trashedDisplay++;
                    trashedKeyMarker -= 2;
                }
            }
            float rageExpenses = (trashedHeadset * headsetPrice) + (trashedMouse * mousePrice) + (trashedKeyboard * keyboardPrice) + (trashedDisplay * displayPrice);
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
