using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            if (people % capacity == 0)
            {
                Console.WriteLine(people / capacity);
            }
            else if (people < capacity)
            {
                Console.WriteLine(1);
            }
            else if (people % capacity != 0)
            {
                int result = (people / capacity) + 1;
                Console.WriteLine(result);
            }
        }
    }
}
