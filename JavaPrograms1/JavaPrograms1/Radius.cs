using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms1
{
    public class Radius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2*(22 / 7 * radius);
            Console.WriteLine("perimeter of a circle is :"+perimeter);
        }
    }
}
