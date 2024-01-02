using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class ExponentDivision
    {
        public static void ExpDivision()
        {
            Console.WriteLine("Enter base");
            double num= double.Parse(Console.ReadLine());
            Console.WriteLine("Enter first Exponent ");
            double exp1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Exponent ");
            double exp2 = double.Parse(Console.ReadLine());
            double div =exp1 - exp2;
            Console.WriteLine("Result is : {0}^{1}:{2}",num,div,Math.Pow(num,div));
        }
    }
}
