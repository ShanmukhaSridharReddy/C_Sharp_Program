using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class SumOfMultiples
    {
        public static void MultipleOf3()
        {
            Console.WriteLine("Enter range ");
            int n= int.Parse(Console.ReadLine());
            Console.WriteLine();
            int sum=0;
            for(int i = 10; i <= n; i++) { 
            if(i%3==0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                    sum =sum + i;
                }
            }
            Console.WriteLine("sum of all Multiples of 3 & 5 "+sum);
        }

    }
}
