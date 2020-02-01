using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesProject.Exercises.Geometry
{
    class ArrayLeftRotate
    {
        public static void Run()
        {
            var array = new string[] { "a", "b", "c" };

            Console.WriteLine($"Before rotate {string.Join(", ", array)}");
            LeftRotate(array);
            Console.WriteLine($"After rotate {string.Join(", ", array)}");

            Console.ReadKey();
        }

        private static void LeftRotate( string[] array )
        {
            var first = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }

            array[array.Length - 1] = first;
        }
    }
}
