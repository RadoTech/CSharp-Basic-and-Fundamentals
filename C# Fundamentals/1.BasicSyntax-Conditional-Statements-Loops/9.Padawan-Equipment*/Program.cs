using System;

namespace padawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            float money = float.Parse(Console.ReadLine());
            int padawansCount = int.Parse(Console.ReadLine());
            float oneLightsabrePrice = float.Parse(Console.ReadLine());
            float oneRobePrice = float.Parse(Console.ReadLine());
            float oneBeltPrice = float.Parse(Console.ReadLine());
            float allLightsabresPrice = (oneLightsabrePrice * padawansCount) + (oneLightsabrePrice * (float)(Math.Ceiling(padawansCount * 0.1)));
            float allRobesPrice = (oneRobePrice * padawansCount);
            float discountedBelts = 0;
            for (int discounted = 0; discounted <= padawansCount; discounted+=6)
            {
                if (discounted > 1)
                {
                    discountedBelts++;
                }
            }
            float allBeltsPrice = (padawansCount - discountedBelts) * oneBeltPrice;
            float totalBill = allLightsabresPrice + allRobesPrice + allBeltsPrice;
            if (totalBill <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalBill:f2}lv.");
            }
            else if (totalBill > money)
            {
                Console.WriteLine($"Ivan Cho will need {(totalBill-money):f2}lv more.");
            }
        }
    }
}
