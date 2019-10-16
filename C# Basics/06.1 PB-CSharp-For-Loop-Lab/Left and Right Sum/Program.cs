using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int groupOneSum = 0;
            int groupTwoSum = 0;

            for (int i = 1; i <= groups * 2; i++)
            {
                if (i <= groups)
                {
                    int groupOne = int.Parse(Console.ReadLine());
                    groupOneSum += groupOne;
                }
                else if (i > groups)
                {
                    int groupTwo = int.Parse(Console.ReadLine());
                    groupTwoSum += groupTwo;
                }
            }
            if (groupOneSum == groupTwoSum)
            {
                Console.WriteLine($"Yes, sum = {groupOneSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(groupOneSum - groupTwoSum)}");
            }

        }
    }
}
