using System;
using System.Linq;


namespace arrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int rotate = 1; rotate <= n; rotate++)
            {
                var temp = inputArray[0];
                for (var i = 1; i < inputArray.Length; i++)
                {
                    inputArray[i - 1] = inputArray[i];
                }
                inputArray[inputArray.Length - 1] = temp;
            }        
            Console.WriteLine(String.Join(" ", inputArray));
        }
    }
}
