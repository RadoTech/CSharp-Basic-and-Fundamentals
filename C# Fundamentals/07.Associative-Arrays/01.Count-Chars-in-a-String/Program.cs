using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, uint> histogram = new Dictionary<char, uint>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (!histogram.ContainsKey(input[i]))
                    {
                        histogram.Add(input[i], 1);
                    }
                    else
                    {
                        histogram[input[i]]++;
                    }
                }
            }
            foreach (var KeyValuePair in histogram)
            {
                Console.WriteLine($"{KeyValuePair.Key} -> {KeyValuePair.Value}");
            }
        }
    }
}
