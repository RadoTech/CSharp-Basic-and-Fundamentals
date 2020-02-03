using System;
using System.Linq;

namespace topIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = String.Empty;
            for (int i = 0; i < inputArray.Length; i++)
            {
                int current = inputArray[i];
                bool isTopInteger = true;
                for (int j = i+1; j < inputArray.Length; j++)
                {
                    int compare = inputArray[j];
                    if (current <= compare)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger == true)
                {
                    result += (current + " ");
                }
            }
            Console.WriteLine(result);
        }
    }
}
