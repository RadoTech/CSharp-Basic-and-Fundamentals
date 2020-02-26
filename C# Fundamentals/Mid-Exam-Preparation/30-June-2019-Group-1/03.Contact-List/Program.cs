using System;
using System.Collections.Generic;

namespace ContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> InputList = new List<string>(Console.ReadLine().Split());
            var InputCommand = new List<string>(Console.ReadLine().Split());

            while (!InputCommand[0].Contains("Print"))
            {
                AddContact(InputList, InputCommand);
                RemoveContact(InputList, InputCommand);
                ExportContact(InputList, InputCommand);
                InputCommand = new List<string>(Console.ReadLine().Split());
            }
            PrintContact(InputList, InputCommand);

        }

        private static void PrintContact(List<string> InputList, List<string> InputCommand)
        {
            if (InputCommand[0].Contains("Print"))
            {
                if (InputCommand[1].Contains("Normal"))
                {
                    Console.WriteLine($"Contacts: {String.Join(" ", InputList)}");
                }
                else if (InputCommand[1].Contains("Reversed"))
                {
                    InputList.Reverse();
                    Console.WriteLine($"Contacts: {String.Join(" ", InputList)}");
                }

            }
        }

        public static List<string> AddContact(List<string> InputList, List<string> InputCommand)
        {
            if (InputCommand[0].Contains("Add"))
            {
                if (InputList.Contains(InputCommand[1]))
                {
                    InputList.Insert(int.Parse(InputCommand[2]), InputCommand[1]);
                }
                else if (!InputList.Contains(InputCommand[1]))
                {
                    InputList.Add(InputCommand[1]);
                }
            }
            return InputList;
        }
        public static List<string> RemoveContact(List<string> InputList, List<string> InputCommand)
        {
            if (InputCommand[0].Contains("Remove"))
            {
                for (int index = 0; index < InputList.Count; index++)
                {
                    if (index == int.Parse(InputCommand[1]))
                    {
                        InputList.RemoveAt(index);
                    }
                }
            }
            return InputList;
        }
        public static void ExportContact(List<string> InputList, List<string> InputCommand)
        {
            if (InputCommand[0].Contains("Export"))
            {
                List<string> ExportList = new List<string>();
                for (int index = 0; index < InputList.Count; index++)
                {
                    int count = (int.Parse(InputCommand[1]) + int.Parse(InputCommand[2])) - 1;
                    if (int.Parse(InputCommand[1]) >= 0 && count < (InputList.Count -1)) //InputCommand[2] - here is count not index
                    {
                        if (index >= int.Parse(InputCommand[1]) && index <= count)
                        {
                            ExportList.Add(InputList[index]);
                        }

                    }
                    else if (int.Parse(InputCommand[1]) >= 0 && count >= (InputList.Count - 1)) //InputCommand[2] - here is count not index
                    {
                        if (index >= int.Parse(InputCommand[1]) && index < InputList.Count)
                        {
                            ExportList.Add(InputList[index]);
                        }
                    }
                }
                Console.WriteLine(String.Join(" ", ExportList));
            }
        }
    }
}
