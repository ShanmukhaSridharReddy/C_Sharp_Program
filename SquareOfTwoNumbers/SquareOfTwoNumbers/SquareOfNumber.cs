using System;
using System.Collections.Generic;
using System.Text;

namespace SquareOfTwoNumbers
{
    public class SquareOfNumber
    {
        public static void Square()
        {
            Console.WriteLine("Enter 1st decimal number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd decimal number");
            double b = double.Parse(Console.ReadLine());
            double s1 = a * a;
            double s2 = b * b;
            double sum = s1 + s2;
            Console.WriteLine("square of sum of two numbers are:"+sum);
            double diff = s1 - s2;
            Console.WriteLine("square of difference between two numbers:"+diff);
        }
    }
}
