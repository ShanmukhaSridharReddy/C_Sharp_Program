using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class Multiplication
    {
        public static void Table()
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine(n + "*" + i + "=" + n * i);
            }
        }
    }
}
