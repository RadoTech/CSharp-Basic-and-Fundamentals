using System;
using System.Collections.Generic;
using System.Linq;

namespace FroggySquad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogsInput = Console.ReadLine().Split().ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            string firstPrint = string.Empty;

            while (!command.Contains("Print"))
            {
                if (command[0].Equals("Join"))
                {
                    frogsInput.Add(command[1]);
                }
                else if (command[0].Equals("Jump"))
                {
                    int currFrogIndex = int.Parse(command[2]);
                    if (int.Parse(command[2]) < frogsInput.Count() && int.Parse(command[2]) > -1)
                    {
                        frogsInput.Insert(currFrogIndex, command[1]);
                    }
                    else if(int.Parse(command[2]) == frogsInput.Count())
                    {
                        frogsInput.Add(command[1]);
                    }
                }
                else if (command[0].Equals("Dive"))
                {
                    if (int.Parse(command[1]) < frogsInput.Count() && int.Parse(command[1]) > -1)
                    {
                        frogsInput.RemoveAt(int.Parse(command[1]));
                    }
                }
                else if (command[0].Equals("First") || command[0].Equals("Last"))
                {
                    if (command[0].Equals("First"))
                    {
                        for (int index = 0; index < frogsInput.Count; index++)
                        {
                            if (index < int.Parse(command[1]))
                            {
                                firstPrint += frogsInput[index] + " ";
                            }
                        }
                        Console.WriteLine(firstPrint);
                    }
                    else if
                        (command[0].Equals("Last"))
                    {
                        List<string> firstPrintToList = new List<string>();
                        for (int index = frogsInput.Count - 1; index >= 0; index--)
                        {
                            if (index >= (frogsInput.Count - int.Parse(command[1])))
                            {
                                firstPrint += frogsInput[index] + " ";
                            }
                        }
                        firstPrintToList = firstPrint.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                        firstPrintToList.Reverse();
                        Console.WriteLine(String.Join(" ", firstPrintToList));
                    }
                }
                firstPrint = string.Empty;
                command = Console.ReadLine().Split().ToList();
            }
            if (command[1].Equals("Normal"))
            {
                Console.WriteLine($"Frogs: {String.Join(" ", frogsInput)}");
                return;
            }
            else if (command[1].Equals("Reversed"))
            {
                frogsInput.Reverse();
                string printOutput = string.Empty;
                foreach (string k in frogsInput)
                {
                    printOutput += k + " ";
                }
                Console.WriteLine($"Frogs: {printOutput}");
                return;
            }
        }
    }
}
