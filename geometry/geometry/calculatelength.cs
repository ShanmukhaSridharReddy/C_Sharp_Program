using System;
using System.Collections.Generic;
using System.Text;

namespace geometry
{
    public class calculatelength
    {
     public static void length()
        {
            Console.WriteLine("Enter X1 value:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1 value:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2 value:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2 value:");
            double y2 = double.Parse(Console.ReadLine());
            double x = x2 - x1;
            double y = y2 - y1;
            double a = x * x;
            double b = y * y;
            double add = a + b;
            double res = (double)Math.Sqrt(add);
            Console.WriteLine("The length of a between two points are:"+res);
           
        }
    }
}
