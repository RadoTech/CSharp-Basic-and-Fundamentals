using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsCount = int.Parse(Console.ReadLine());
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger snowballMaxValue = -1;
            int snowballMaxSnow = 0;
            int snowballMaxTime = 0;
            int snowballMaxQuality = 0;
            for (int snowball = 1; snowball <= snowballsCount; snowball++)
            {
                int snowTimeToDouble = (snowballSnow / snowballTime);
                snowballValue = BigInteger.Pow(snowTimeToDouble, snowballQuality);
                if (snowballValue > snowballMaxValue)
                {
                    snowballMaxValue = snowballValue;
                    snowballMaxSnow = snowballSnow;
                    snowballMaxTime = snowballTime;
                    snowballMaxQuality = snowballQuality;
                }
                if (snowball == snowballsCount)
                {
                    break;
                }
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{snowballMaxSnow} : {snowballMaxTime} = {snowballMaxValue} ({snowballMaxQuality})");
        }
    }
}
