using System;
using System.Linq;

namespace maxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string match = string.Empty;
            string bestMatch = string.Empty;
            string firstMatch = string.Empty;
            for (int first = 0; first < array.Length; first++)
            {
                int currentFirst = array[first];
                for (int second = first + 1; second < array.Length; second++)
                {
                    int currentSecond = array[second];
                    if (currentFirst == currentSecond)
                    {
                        match += currentFirst + " ";
                    }
                    else if (first != second)
                    {
                        break;
                    }
                }
                firstMatch = match + currentFirst;
                match = string.Empty;
                if (firstMatch.Length > bestMatch.Length)
                {
                    bestMatch = firstMatch;
                }
            }
            Console.WriteLine(bestMatch);
        }
    }
}
