using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class SwapTwoNumbers
    {
        public static void SwapNumber()
        {
            Console.WriteLine("Enter 1st Number");
            int  a= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int b= int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a+" "+b);
        }
    }
}
