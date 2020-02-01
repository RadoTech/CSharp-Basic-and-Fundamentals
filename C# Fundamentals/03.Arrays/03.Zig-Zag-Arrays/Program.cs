using System;
using System.Linq;

namespace zigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] joinArray = new int[n];
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                joinArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    firstArray[i] = joinArray[0];
                    secondArray[i] = joinArray[1];
                }
                else if (i % 2 != 0)
                {
                    firstArray[i] = joinArray[1];
                    secondArray[i] = joinArray[0];
                }
            }
            Console.WriteLine(String.Join(" ", firstArray));
            Console.WriteLine(String.Join(" ", secondArray));
        }
    }
}
