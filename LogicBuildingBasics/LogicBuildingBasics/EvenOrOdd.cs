using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class EvenOrOdd
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            if( number%2 == 0)
            {
                Console.WriteLine(number + " is Even");
            }
            else
            {
                Console.WriteLine(number+" is Odd");
            }
        }
    }
}
