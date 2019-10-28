using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //output
            int dogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            //logic
            double dogsMealPrice = 2.5;
            double otherAnimalsPrice = 4;

            double dogsBill = dogs * dogsMealPrice;
            double otherAnimalsBill = otherAnimals * otherAnimalsPrice;
            double totalBill = dogsBill + otherAnimalsBill;

            //output

            Console.WriteLine($"{totalBill:F2} lv.");
        }
    }
}
