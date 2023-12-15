using System;
using System.Collections.Generic;
using System.Text;

namespace C_BasicPrograms
{
    public class OddNumber
    {
        public static void RangeInOdd()
        {
            for( int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i+" This Number is Odd");
            }
        }
    }
}
