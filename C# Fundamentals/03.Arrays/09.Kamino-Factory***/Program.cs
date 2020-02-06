using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] maxArray = new int[n];
            int maxCount = 0;
            int maxIndex = 0;
            int maxSample = 1; //every input will has at least 1st sample, hence maxSample starts at 1;
            int currSample = 0;

            while (true) //!!!while loop declaring before the input "line"!!! and put all logic for one turn into the while loop!!!
            {
                string line = Console.ReadLine();
                if (line == "Clone them!")
                {
                    break;
                }
                int[] currArr = line //changed to "line" from "Console.ReadLine()", after declaring the while loop
                               .Split("!", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
                currSample++;
                int bestCurrCount = 0; //ctrl+RR from "bestCount" to "bestCurrCount" after declaring the while loop
                int bestCurrIndex = 0; //ctrl+RR from "bestIndex" to "bestCurrIndex" after declaring the while loop
                int bestCurrSum = 0;   //ctrl+RR from "bestSum" to "bestCurrSum" after declaring the while loop


                for (int currIndex = 0; currIndex < currArr.Length; currIndex++)
                {
                    int currElement = currArr[currIndex];
                    int currCount = 1;
                    if (currElement == 0)
                    {
                        continue;
                    }
                    for (int index = currIndex + 1; index < currArr.Length; index++)
                    {
                        if (currArr[index] == 1)
                        {
                            currCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currCount > bestCurrCount)
                    {
                        bestCurrCount = currCount;
                        bestCurrIndex = currIndex;
                        bestCurrSum = currArr.Sum();
                        
                    }
                }
                //after the array(when the best has been found)
                if ((bestCurrCount > maxCount) ||
                   (bestCurrCount == maxCount && maxIndex > bestCurrIndex) ||
                   (maxArray.Sum() < bestCurrSum))                 
                {
                    maxIndex = bestCurrIndex;
                    maxCount = bestCurrCount;
                    maxArray = currArr;
                    maxSample = currSample;
                }
            }
            Console.WriteLine($"Best DNA sample {maxSample} with sum: {maxArray.Sum()}.");
            Console.WriteLine(string.Join(" ", maxArray));
        }
    }
}
