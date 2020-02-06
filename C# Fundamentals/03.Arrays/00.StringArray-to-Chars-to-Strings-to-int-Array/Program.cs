using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputString = Console.ReadLine();
            string inputSequence = string.Empty;
            while (inputString != "Clone them!")
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    char ch = inputString[i];
                    if (ch == '!')
                    {
                        ch = ' ';
                    }
                    string letter = ch.ToString();
                    inputSequence += letter;
                }
                int[] inputArray = inputSequence.Split().Select(int.Parse).ToArray();
            }
        }
    }
}
                