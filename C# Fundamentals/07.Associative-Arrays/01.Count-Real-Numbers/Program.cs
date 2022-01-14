using System;
using System.Linq;
using System.Collections.Generic;

namespace CountRealNumbers_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> repeatsDict = new SortedDictionary<double, int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (!repeatsDict.ContainsKey(inputNumbers[i]))
                {
                    repeatsDict.Add(inputNumbers[i], 1);
                }
                else
                {
                    repeatsDict[inputNumbers[i]]++;
                }
            }
            foreach (var item in repeatsDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
