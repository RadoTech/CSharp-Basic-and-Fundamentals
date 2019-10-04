using System;
using System.Collections.Generic;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string demo = "PC has a new RAM";
            //string[] strArray = demo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //string secondEL = strArray[1];
            //List<object> newList = new List<object>();



            //input

            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string operators = Console.ReadLine();


            //logic
            double resultN1N2 = 0.00;
            string initialOutputType = "zero";
            string outputTypeA = "a";
            string outputTypeB = "b";
            string outputTypeC = "c";
            string outputTypeD = "d";

            if (operators == "+")
            {
                resultN1N2 = N1 + N2;
                initialOutputType = outputTypeA;
            }
            else if (operators == "-")
            {
                resultN1N2 = N1 - N2;
                initialOutputType = outputTypeA;
            }
            else if (operators == "*")
            {
                resultN1N2 = N1 * N2;
                initialOutputType = outputTypeA;
            }
            else if (operators == "/" && N2 != 0)
            {
                resultN1N2 = N1 / N2;
                initialOutputType = outputTypeB;
            }
            else if (operators == "%" && N2 != 0)
            {
                resultN1N2 = N1 % N2;
                initialOutputType = outputTypeC;
            }
            else if ((operators == "/" && N2 == 0) || (operators == "%" && N2 == 0))
            {
                initialOutputType = outputTypeD;
            }

            string evenOdd = "";
            string even = "even";
            string odd = "odd";

            if (resultN1N2 % 2 == 0)
            {
                evenOdd = even;
            }
            else
            {
                evenOdd = odd;
            }
            //output

            if (initialOutputType == outputTypeA)
            {
                Console.WriteLine($"{N1} {operators} {N2} = {resultN1N2} - {evenOdd}");
            }
            else if (initialOutputType == outputTypeB)
            {
                Console.WriteLine($"{N1} / {N2} = {resultN1N2:f2}");
            }
            else if (initialOutputType == outputTypeC)
            {
                Console.WriteLine($"{N1} % {N2} = {resultN1N2}");
            }
            else if (initialOutputType == outputTypeD)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }

        }
    }
}
