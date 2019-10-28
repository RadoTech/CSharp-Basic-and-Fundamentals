using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double sqMeters = double.Parse(Console.ReadLine());

            //logic
            //1 square meter = 7.61 BGN with taxes
            //discount 18% of total sum

            double sqMetersRate = 7.61;
            double sqMeterHome = sqMeters * sqMetersRate;
            double discount = sqMeterHome * 0.18;
            double finalPrice = sqMeterHome - discount;

            //output

            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");

        }
    }
}
