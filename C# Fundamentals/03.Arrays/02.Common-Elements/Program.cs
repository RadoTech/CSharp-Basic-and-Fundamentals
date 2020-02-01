using System;

namespace commonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split();
            string[] arrayTwo = Console.ReadLine().Split();
            for (int second = 0; second < arrayTwo.Length; second++)
            {
                for (int first = 0; first < arrayOne.Length; first++)
                {
                    if (arrayTwo[second] == arrayOne[first])
                    {
                        string match = arrayOne[first];
                        Console.Write(String.Join(" ",match + " "));
                    }
                }
            }
        }
    }
}
