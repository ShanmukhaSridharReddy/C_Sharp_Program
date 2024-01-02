using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class PositiveNumberOrNot
    {
        public static void positiveNumber()
        {
            Console.WriteLine("enter any number");
            Double n = Double.Parse(Console.ReadLine());
            if (n > 0)
                Console.WriteLine(n+" Positive Number");
            else
                Console.WriteLine(n+" Negative Number");
        }
    }
}
