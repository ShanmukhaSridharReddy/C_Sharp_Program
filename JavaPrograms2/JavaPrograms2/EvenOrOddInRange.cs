using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms2
{
    public class EvenOrOddInRange
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter Range");
            int n=int.Parse(Console.ReadLine());
            for( int i = 1; i <= n; i++ )
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+" is Even");
                }
                else
                    Console.WriteLine(i+" is Odd");
            }
        }
    }
}
