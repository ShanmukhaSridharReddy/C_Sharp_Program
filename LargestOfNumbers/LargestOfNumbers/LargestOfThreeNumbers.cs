using System;
using System.Collections.Generic;
using System.Text;

namespace LargestOfNumbers
{
    public class LargestOfThreeNumbers
    {
        public static void ThreeNumbers()
        {
            Console.WriteLine("Enter a value:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b value:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c value:");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is greater");
                }
                else
                {
                    Console.WriteLine("c is greater");
                }
            }
            if(b > c)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greater");
            }

        }
    }
}
