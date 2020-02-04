using System;
using System.Linq;

namespace magicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            for (int first = 0; first < array.Length; first++)
            {
                int firstNum = array[first];
                for (int next = first + 1; next < array.Length; next++)
                {
                    int nextNum = array[next];
                    int sumNum = firstNum + nextNum;
                    if (sumNum == magicNum)
                    {
                        int[] magicArray = new int[2];
                        magicArray[0] = firstNum;
                        magicArray[1] = nextNum;
                        Console.WriteLine(String.Join(" ", magicArray));
                    }
                }
            }
        }
    }
}
