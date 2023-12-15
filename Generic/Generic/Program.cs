using System;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 42;
            int num2 = 19;
            int num3 = 73;

            int greatestInt = MaxInteger.FindGreatest(num1, num2, num3, (x, y) => x > y);
            Console.WriteLine($"The greatest integer is: {greatestInt}");

            double double1 = 3.14;
            double double2 = 2.71;
            double double3 = 1.618;

            double greatestDouble = MaxInteger.FindGreatest(double1, double2, double3, (x, y) => x > y);
            Console.WriteLine($"The greatest double is: {greatestDouble}");
        }
    }
}
