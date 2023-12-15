using System;
using System.Collections.Generic;
using System.Text;

namespace C_BasicPrograms
{
    class EvenOdd
    {
        public static void EvenOrOdd() 
        {
            Console.WriteLine("Enter Any number");
            int n = int.Parse(Console.ReadLine());
            if(n%2 == 0)
            {
                Console.WriteLine("Even");

            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
