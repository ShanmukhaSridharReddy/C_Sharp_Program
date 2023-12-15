using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms2
{
     public class FactorCount
    {
        public static void count()
        {
            Console.WriteLine("Enter a Number");
            int n= int.Parse(Console.ReadLine());
            int count = 0;
            for ( int i=1; i<=n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
