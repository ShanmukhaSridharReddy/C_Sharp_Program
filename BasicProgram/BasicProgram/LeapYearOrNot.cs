using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public static class LeapYearOrNot
    {
        public static void LeapYear()
        {

            Console.WriteLine("Enter Number:");
            int year = int.Parse(Console.ReadLine());
            if(year %400 == 0 || year %4 ==0 && year %100!=0)
            {
                Console.WriteLine( "It's a leap Year");

            }
            else
            {
                Console.WriteLine("It's not a leap year");
            }
        }
    }
}
