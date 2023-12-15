using System;
using System.Collections.Generic;
using System.Text;

namespace geometry
{
    public class EquqlityOfTwoLine
    {
        public static void TwoLines()
        {
            Console.WriteLine("Enter X1 value:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1 value:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2 value:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2 value:");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter x3 value:");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y3 value:");
            double y3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter x4 value:");
            double x4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y4 value:");
            double y4 = double.Parse(Console.ReadLine());
            double x = x2 - x1;
            double y = y2 - y1; 
            double a = x * x;
            double b = y * y;
            double add = a + b;
            double res = (double)Math.Sqrt(add);
            double s = x4 - x3;
            double  f= y4 - y3;
            double c = s * s;
            double d = f * f;
            double add1 = c + d;
            double res1 = (double)Math.Sqrt(add1);
            if(res == res1)
            {
                Console.WriteLine("both the lines are equals");
            }
            else
            {
                Console.WriteLine("lines are not equal");
            }
        }
    }
}
