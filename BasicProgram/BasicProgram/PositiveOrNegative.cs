using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class PositiveOrNegative
    {
        public static void PositiveNumberOrNegativeNumber()
        {
            Console.WriteLine("enter number:");
            int n= int.Parse(Console.ReadLine());
            if( n==0 || n> 0 )
            {
                Console.WriteLine("it's positive number");
            }
            else
            {
                Console.WriteLine("it's a negative number");
            }
        }
    }
}
