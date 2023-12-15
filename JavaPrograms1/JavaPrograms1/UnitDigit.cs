using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms1
{
    public class UnitDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int num = int.Parse(Console.ReadLine());
            int n = num % 10;
            Console.WriteLine(n);
        }
    }
}
