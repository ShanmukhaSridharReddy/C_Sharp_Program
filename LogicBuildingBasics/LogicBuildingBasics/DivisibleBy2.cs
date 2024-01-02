using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class DivisibleBy2
    {
        public static void Divisible2(){
            Console.WriteLine("Enter Range");
            int n= int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+" divisible by 2");
                }
            }
        }
    }
}
