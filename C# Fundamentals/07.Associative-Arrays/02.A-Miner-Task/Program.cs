using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOre = Console.ReadLine();
            ulong inputVolume = ulong.Parse(Console.ReadLine());
            Dictionary<string, ulong> minerProduction = new Dictionary<string, ulong>();
            while (inputOre != "stop")
            {
                if (!minerProduction.ContainsKey(inputOre))
                {
                    minerProduction.Add(inputOre, inputVolume);
                }
                else
                {
                    minerProduction[inputOre] += inputVolume;
                }
                inputOre = Console.ReadLine();
                if (inputOre == "stop")
                {
                    break;
                }
                inputVolume = ulong.Parse(Console.ReadLine());
            }
            foreach (var ore in minerProduction)
            {
                Console.WriteLine($"{ore.Key} -> {ore.Value}");
            }
        }
    }
}
