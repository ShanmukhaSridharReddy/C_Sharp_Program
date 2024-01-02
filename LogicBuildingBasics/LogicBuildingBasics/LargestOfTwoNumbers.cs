using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class LargestOfTwoNumbers
    {
        public static void LargestNumber()
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());
            if (a > b) Console.WriteLine(" a is big");
            else Console.WriteLine(" b is big");
        }
    }
}
