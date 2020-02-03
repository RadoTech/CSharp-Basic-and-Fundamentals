using System;
using System.Linq;

namespace equalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isIndex = false;
            for (int index = 0; index < array.Length; index++)
            {
                int sumRight = 0;
                for (int i = index + 1; i < array.Length; i++)
                {
                    sumRight += array[i];
                }
                int leftSum = 0;
                for (int i = index - 1; i >= 0; i--)
                {
                    leftSum += array[i];
                }
                if (sumRight == leftSum)
                {
                    isIndex = true;
                    Console.WriteLine(index);
                }
            }
            if (!isIndex)
            {
                Console.WriteLine("no");
            }
        }
    }
}
