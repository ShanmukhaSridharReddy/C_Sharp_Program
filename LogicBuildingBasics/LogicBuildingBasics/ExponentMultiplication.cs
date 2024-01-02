using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class ExponentMultiplication
    {
        public static void MultiplicationExponent()
        {
            Console.WriteLine("Enter Base");
            double baseNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter first Exponent");
            double exp1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Exponent");
            double exp2 = double.Parse(Console.ReadLine());
            double mul = exp1 + exp2;
            Console.WriteLine("Result is: {0}^{1} : {2}",baseNum,mul,Math.Pow(baseNum,mul));
        }
    }
}
