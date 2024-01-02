using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class OddNumberRange
    {
        public static void OddNumber()
        {
            Console.WriteLine("Enter Range Number");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("The Odd Numbers Are");
            for(int i = 0; i <= r; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
    }
}
