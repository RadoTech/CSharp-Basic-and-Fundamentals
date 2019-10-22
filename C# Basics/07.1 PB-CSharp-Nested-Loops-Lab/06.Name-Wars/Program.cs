using System;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int charSum = 0;
            int maxSum = int.MinValue;
            string maxName = "N/A";
            

            while (name != "STOP")
            {
                int len = name.Length;
                for (int i = 0; i < len; i++)
                {
                    char letter = name[i];
                    charSum += letter;
                }
                if (charSum > maxSum)
                {
                    maxSum = charSum;
                    maxName = name;
                }
                charSum = 0;
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {maxName} - {maxSum}!");
        }
    }
}
